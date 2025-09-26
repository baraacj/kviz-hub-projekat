using System.ComponentModel.DataAnnotations;

namespace KvizHub.Api.Models;

public class User {
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string Username { get; set; } = default!;
    [Required] public string Email { get; set; } = default!;
    [Required] public string PasswordHash { get; set; } = default!;
    public string? DisplayName { get; set; }
    public string? AvatarUrl { get; set; }
    public bool IsAdmin { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
