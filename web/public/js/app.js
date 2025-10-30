async function apiFetch(url, method='GET', body=null, auth=true) {
  const headers = { 'Content-Type': 'application/json' };
  if (auth) {
    const token = localStorage.getItem('token');
    if (!token) return { message: 'Not authenticated' };
    headers['Authorization'] = 'Bearer ' + token;
  }
  const res = await fetch(url, {
    method,
    headers,
    body: body ? JSON.stringify(body) : undefined
  });
  const data = await res.json().catch(() => ({}));
  return data;
}
