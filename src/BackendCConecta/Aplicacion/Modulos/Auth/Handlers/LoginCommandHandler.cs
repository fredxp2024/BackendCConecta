using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Auth.Comandos;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Handlers

{

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<LoginResponseDto>>
    {
        private readonly IAuthService _authService;

        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<Result<LoginResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var loginRequest = new LoginRequestDto
            {
                Correo = request.CorreoElectronico,
                Password = request.Password
            };

            return await _authService.LoginAsync(loginRequest, cancellationToken);
        }
    }
}
