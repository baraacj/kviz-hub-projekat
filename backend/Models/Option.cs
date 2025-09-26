using System.ComponentModel.DataAnnotations;

namespace KvizHub.Api.Models;

public class Option {
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid QuestionId { get; set; }
    [Required] public string Text { get; set; } = default!;
    public bool IsCorrect { get; set; } = false;
}
