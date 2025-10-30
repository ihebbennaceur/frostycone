# The Forsty Cone - Web version (minimal)

This is a minimal web version of your desktop project. It uses Node.js + Express and connects to the same SQL Server database used by the desktop app.

What is included
- Backend: `server.js` (Express, MSSQL) with PBKDF2 password hashing compatible with your C# `PasswordHasher`
- Frontend: static files in `public/` (`index.html`, `login.html`, `admin.html`, `css`, `js`)

Quick start
1. Copy `.env.example` to `.env` and adjust `DB_CONN` and `JWT_SECRET`.
2. From the `web` folder run:

```powershell
npm install
npm start
```

3. Open http://localhost:3000 in your browser.

Notes
- The example DB connection uses Windows Integrated Security. If your Node process cannot connect using integrated auth, provide SQL Server username/password in the connection string instead.
- The password hashing uses PBKDF2 with the same parameters as your C# `PasswordHasher` (salt 16 bytes, hash 20 bytes, 10000 iterations) so passwords created by the desktop app will work with this web version.

Security
- This is a minimal example. For production use, use HTTPS, a secure session store, stronger JWT expiry and rotation, input validation, rate limits, and avoid sending secrets via plaintext.

Next steps you may want
- Add client-side form validation
- Add user profile, product lists and basket endpoints to match desktop app features
- Improve UI/UX using a front-end framework or templates
