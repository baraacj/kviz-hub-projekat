using KvizHub.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KvizHub.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class QuizzesController : ControllerBase
{
    private readonly AppDbContext _db;
    public QuizzesController(AppDbContext db) { _db = db; }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var quizzes = await _db.Quizzes.AsNoTracking().Select(q => new {
            q.Id, q.Title, q.Description, q.Difficulty, q.TimeLimitSeconds, q.TotalQuestions
        }).ToListAsync();
        return Ok(quizzes);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] dynamic dto)
    {
        // minimal create (admin checks omitted in skeleton)
        var quiz = new KvizHub.Api.Models.Quiz {
            Title = dto.title ?? "Untitled",
            Description = dto.description,
            Difficulty = Enum.TryParse<KvizHub.Api.Models.QuizDifficulty>((string?)dto.difficulty, out var d) ? d : KvizHub.Api.Models.QuizDifficulty.MEDIUM,
            TimeLimitSeconds = (int?)(dto.timeLimitSeconds ?? 600) ?? 600,
            TotalQuestions = (int?)(dto.totalQuestions ?? 0) ?? 0
        };
        _db.Quizzes.Add(quiz);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = quiz.Id }, quiz);
    }
}
