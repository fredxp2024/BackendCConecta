using MediatR;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Comandos
{
    public class RefreshTokenCommand : IRequest<LoginResponseDto>
    {
        public string Token { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}

