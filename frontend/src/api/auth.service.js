import axios from "axios";
const API = import.meta.env.VITE_API_URL || "http://localhost:5000/api/v1";

export async function login(usernameOrEmail, password) {
  const res = await axios.post(`${API}/auth/login`, { usernameOrEmail, password });
  localStorage.setItem("token", res.data.accessToken);
  return res.data;
}

export async function register(payload) {
  return axios.post(`${API}/auth/register`, payload);
}
