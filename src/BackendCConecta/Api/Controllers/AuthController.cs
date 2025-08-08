using Microsoft.AspNetCore.Mvc;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Api.Responses;

namespace BackendCConecta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ApiResponse<string>.Failure("Datos inválidos."));
            }

            var result = await _authService.LoginAsync(request);
            if (!result.Success)
            {
                return Unauthorized(ApiResponse<string>.Failure(result.Error!));
            }

            return Ok(ApiResponse<LoginResponseDto>.SuccessResponse(result.Data!));
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
        {
            if (string.IsNullOrWhiteSpace(refreshToken))
            {
                return BadRequest(ApiResponse<string>.Failure("Token inválido."));
            }

            var result = await _authService.RefreshTokenAsync(refreshToken);
            if (result is null)
            {
                return Unauthorized(ApiResponse<string>.Failure("Token no válido."));
            }

            return Ok(ApiResponse<LoginResponseDto>.SuccessResponse(result));
        }
    }
}
