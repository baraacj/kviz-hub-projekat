import "./Home.css";
import React, { useEffect, useState } from "react";
import { getQuizzes } from "../../api/quiz.service";

export default function Home() {
  const [quizzes, setQuizzes] = useState([]);
  useEffect(() => {
    getQuizzes().then(r => setQuizzes(r || []));
  }, []);
  return (
    <div className="container">
      <h1>KvizHub - Dostupni kvizovi</h1>
      <div>
        {quizzes.length === 0 && <p>Ne postoji kviz ili backend nije pokrenut.</p>}
        {quizzes.map(q => (
          <div key={q.id} className="card" style={{marginTop: 8}}>
            <h3>{q.title}</h3>
            <p>{q.description}</p>
            <small>Težina: {q.difficulty} | Pitanja: {q.totalQuestions}</small>
          </div>
        ))}
      </div>
    </div>
  );
}
