using System.ComponentModel.DataAnnotations;

namespace KvizHub.Api.Models;

public enum QuizDifficulty { EASY, MEDIUM, HARD }

public class Quiz {
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public QuizDifficulty Difficulty { get; set; } = QuizDifficulty.MEDIUM;
    public int TimeLimitSeconds { get; set; } = 600;
    public int TotalQuestions { get; set; } = 0;
    public Guid? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
