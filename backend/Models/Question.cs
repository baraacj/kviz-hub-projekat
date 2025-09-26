using System.ComponentModel.DataAnnotations;

namespace KvizHub.Api.Models;

public enum QuestionType { SINGLE_CHOICE, MULTI_CHOICE, TRUE_FALSE, FILL_BLANK }

public class Question {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid QuizId { get; set; }
    [Required] public string Text { get; set; } = default!;
    public QuestionType QuestionType { get; set; } = QuestionType.SINGLE_CHOICE;
    public int Points { get; set; } = 1;
    public int Order { get; set; } = 0;
}
