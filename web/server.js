const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const mssql = require('mssql');
const crypto = require('crypto');
const jwt = require('jsonwebtoken');
require('dotenv').config();

const app = express();
app.use(cors());
app.use(bodyParser.json());
app.use(express.static('public'));

const PORT = process.env.PORT || 3000;
const DB_CONN = process.env.DB_CONN || "Data Source=ZAK-PC;Initial Catalog='the frosty cone';Integrated Security=True;TrustServerCertificate=True";
const JWT_SECRET = process.env.JWT_SECRET || 'change_this_to_a_strong_secret';

// PBKDF2 parameters must match the C# PasswordHasher
const SALT_SIZE = 16; // bytes
const HASH_SIZE = 20; // bytes
const ITERATIONS = 10000;

function hashPassword(password) {
  const salt = crypto.randomBytes(SALT_SIZE);
  const derived = crypto.pbkdf2Sync(password, salt, ITERATIONS, HASH_SIZE, 'sha1');
  const combined = Buffer.concat([salt, derived]);
  return combined.toString('base64');
}

function verifyPassword(password, stored) {
  try {
    const hashBytes = Buffer.from(stored, 'base64');
    const salt = hashBytes.slice(0, SALT_SIZE);
    const storedHash = hashBytes.slice(SALT_SIZE);
    const derived = crypto.pbkdf2Sync(password, salt, ITERATIONS, HASH_SIZE, 'sha1');
    return crypto.timingSafeEqual(storedHash, derived);
  } catch (e) {
    return false;
  }
}

async function queryGetUserByUsername(username) {
  const pool = await mssql.connect(DB_CONN);
  const request = pool.request();
  request.input('username', mssql.NVarChar, username);
  const result = await request.query("SELECT id, username, isadmin, [password] FROM users WHERE UPPER(username) = UPPER(@username)");
  pool.close();
  return result.recordset[0];
}

async function getAllUsers() {
  const pool = await mssql.connect(DB_CONN);
  const result = await pool.request().query('SELECT id, username, isadmin FROM users');
  pool.close();
  return result.recordset;
}

async function deleteUserById(id) {
  const pool = await mssql.connect(DB_CONN);
  await pool.request().input('id', mssql.Int, id).query('DELETE FROM users WHERE id = @id');
  pool.close();
}

async function createUser(username, email, password, dob, isAdmin) {
  const hashed = hashPassword(password);
  const pool = await mssql.connect(DB_CONN);
  await pool.request()
    .input('username', mssql.NVarChar, username)
    .input('email', mssql.NVarChar, email)
    .input('password', mssql.NVarChar, hashed)
    .input('dob', mssql.NVarChar, dob)
    .input('isadmin', mssql.Int, isAdmin ? 1 : 0)
    .query('INSERT INTO users (username, email, [password], DOB, isadmin) VALUES (@username, @email, @password, @dob, @isadmin)');
  pool.close();
}

async function verifyUserForReset(email, username, dob) {
  const pool = await mssql.connect(DB_CONN);
  const result = await pool.request()
    .input('email', mssql.NVarChar, email)
    .input('username', mssql.NVarChar, username)
    .input('dob', mssql.NVarChar, dob)
    .query('SELECT COUNT(*) AS cnt FROM users WHERE UPPER(email)=UPPER(@email) AND UPPER(username)=UPPER(@username) AND dob=@dob');
  pool.close();
  return result.recordset[0].cnt > 0;
}

async function updatePasswordByEmail(email, newPassword) {
  const hashed = hashPassword(newPassword);
  const pool = await mssql.connect(DB_CONN);
  const result = await pool.request()
    .input('password', mssql.NVarChar, hashed)
    .input('email', mssql.NVarChar, email)
    .query('UPDATE users SET [password] = @password WHERE email = @email');
  pool.close();
  return result.rowsAffected[0] > 0;
}

// Auth middleware
function authenticateToken(req, res, next) {
  const auth = req.headers['authorization'];
  if (!auth) return res.status(401).json({ message: 'No token' });
  const token = auth.split(' ')[1];
  if (!token) return res.status(401).json({ message: 'No token' });
  try {
    const payload = jwt.verify(token, JWT_SECRET);
    req.user = payload;
    next();
  } catch (e) {
    return res.status(401).json({ message: 'Invalid token' });
  }
}

function requireAdmin(req, res, next) {
  if (!req.user || req.user.isAdmin !== 1) return res.status(403).json({ message: 'Admin only' });
  next();
}

// Routes
app.post('/api/login', async (req, res) => {
  const { username, password } = req.body;
  if (!username || !password) return res.status(400).json({ message: 'username and password required' });
  try {
    const user = await queryGetUserByUsername(username);
    if (!user) return res.status(401).json({ message: 'Invalid credentials' });
    const ok = verifyPassword(password, user.password);
    if (!ok) return res.status(401).json({ message: 'Invalid credentials' });
    const token = jwt.sign({ id: user.id, username: user.username, isAdmin: user.isadmin }, JWT_SECRET, { expiresIn: '8h' });
    res.json({ token, user: { id: user.id, username: user.username, isAdmin: user.isadmin } });
  } catch (e) {
    console.error(e);
    res.status(500).json({ message: 'Server error' });
  }
});

app.post('/api/register', async (req, res) => {
  const { username, email, password, dob } = req.body;
  if (!username || !email || !password || !dob) return res.status(400).json({ message: 'missing fields' });
  try {
    await createUser(username, email, password, dob, 0);
    res.json({ message: 'registered' });
  } catch (e) {
    console.error(e);
    res.status(500).json({ message: 'Server error' });
  }
});

app.post('/api/forgot', async (req, res) => {
  const { email, username, dob, newPassword } = req.body;
  if (!email || !username || !dob || !newPassword) return res.status(400).json({ message: 'missing fields' });
  try {
    const ok = await verifyUserForReset(email, username, dob);
    if (!ok) return res.status(400).json({ message: 'User not found or details do not match' });
    const updated = await updatePasswordByEmail(email, newPassword);
    if (updated) res.json({ message: 'Password updated' });
    else res.status(500).json({ message: 'Could not update password' });
  } catch (e) {
    console.error(e);
    res.status(500).json({ message: 'Server error' });
  }
});

app.get('/api/users', authenticateToken, requireAdmin, async (req, res) => {
  try {
    const users = await getAllUsers();
    res.json(users);
  } catch (e) {
    console.error(e);
    res.status(500).json({ message: 'Server error' });
  }
});

app.delete('/api/users/:id', authenticateToken, requireAdmin, async (req, res) => {
  const id = parseInt(req.params.id, 10);
  if (!id) return res.status(400).json({ message: 'Invalid id' });
  if (id === req.user.id) return res.status(400).json({ message: 'Cannot delete your own account' });
  try {
    await deleteUserById(id);
    res.json({ message: 'Deleted' });
  } catch (e) {
    console.error(e);
    res.status(500).json({ message: 'Server error' });
  }
});

app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});
