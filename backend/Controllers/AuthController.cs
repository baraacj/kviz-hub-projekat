using KvizHub.Api.Dtos;
using KvizHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace KvizHub.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _auth;

    public AuthController(IAuthService auth) { _auth = auth; }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        try {
            var user = await _auth.RegisterAsync(dto);
            return Ok(new { user.Id, user.Username, user.Email, user.DisplayName });
        } catch (Exception ex) {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var token = await _auth.LoginAsync(dto);
        if (token == null) return Unauthorized(new { message = "Invalid credentials" });
        return Ok(new { accessToken = token, expiresIn = 3600 });
    }
}
