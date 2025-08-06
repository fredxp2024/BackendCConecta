using MediatR;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Comandos
{
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        public string CorreoElectronico { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
