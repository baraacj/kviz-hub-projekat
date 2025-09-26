import axios from "axios";
const API = import.meta.env.VITE_API_URL || "http://localhost:5000/api/v1";

export async function getQuizzes() {
  try {
    const res = await axios.get(`${API}/quizzes`);
    return res.data;
  } catch (err) {
    console.error(err);
    return [];
  }
}
