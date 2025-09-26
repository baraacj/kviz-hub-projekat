namespace KvizHub.Api.Models;

public class AttemptAnswer {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AttemptId { get; set; }
    public Guid QuestionId { get; set; }
    public string? AnswerText { get; set; }
    public Guid[]? SelectedOptionIds { get; set; }
    public bool? IsCorrect { get; set; }
    public int PointsAwarded { get; set; } = 0;
}
