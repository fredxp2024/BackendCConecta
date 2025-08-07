using System;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Dominio.Repositorios;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IPasswordHasher _passwordHasher;

        public AuthService(
            IUsuarioRepository usuarioRepository,
            IJwtTokenGenerator jwtTokenGenerator,
            IPasswordHasher passwordHasher)
        {
            _usuarioRepository = usuarioRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
            _passwordHasher = passwordHasher;
        }

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto request, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(request.Correo) || string.IsNullOrWhiteSpace(request.Password))
            {
                return null;
            }

            var usuario = await _usuarioRepository.ObtenerPorCorreoAsync(request.Correo, cancellationToken);
            if (usuario is null || !string.Equals(usuario.Estado, "activo", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            if (!_passwordHasher.VerificarPassword(request.Password, usuario.PasswordHash))
            {
                return null;
            }

            var accessToken = _jwtTokenGenerator.GenerarToken(usuario);
            var refreshToken = Guid.NewGuid().ToString();

            return new LoginResponseDto
            {
                IdUsuario = usuario.IdUsuario,
                Correo = usuario.CorreoElectronico,
                TipoAcceso = usuario.TipoAcceso,
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

        public Task<LoginResponseDto?> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            // La lógica de refresh token dependerá del almacenamiento elegido.
            // Se devuelve null como marcador hasta que se implemente.
            return Task.FromResult<LoginResponseDto?>(null);
        }
    }
}
