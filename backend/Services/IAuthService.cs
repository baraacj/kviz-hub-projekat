using KvizHub.Api.Dtos;
using KvizHub.Api.Models;

namespace KvizHub.Api.Services;

public interface IAuthService
{
    Task<User> RegisterAsync(RegisterDto dto);
    Task<string?> LoginAsync(LoginDto dto);
}
