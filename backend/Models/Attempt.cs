namespace KvizHub.Api.Models;

public class Attempt {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid? UserId { get; set; }
    public Guid? QuizId { get; set; }
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? FinishedAt { get; set; }
    public int Score { get; set; } = 0;
    public decimal Percentage { get; set; } = 0;
    public int? DurationSeconds { get; set; }
}
