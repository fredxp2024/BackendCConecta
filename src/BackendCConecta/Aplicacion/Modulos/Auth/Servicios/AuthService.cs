using System;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Dominio.Entidades.Usuarios;
using Microsoft.Extensions.Logging;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ILogger<AuthService> _logger;

        public AuthService(
            IUsuarioRepository usuarioRepository,
            IJwtTokenGenerator jwtTokenGenerator,
            IPasswordHasher passwordHasher,
            ILogger<AuthService> logger)
        {
            _usuarioRepository = usuarioRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
            _passwordHasher = passwordHasher;
            _logger = logger;
        }

        public async Task<Result<LoginResponseDto>> LoginAsync(LoginRequestDto request, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(request.Correo) || string.IsNullOrWhiteSpace(request.Password))
            {
                _logger.LogWarning("Login attempt with missing credentials");
                return Result<LoginResponseDto>.Failure("Correo y contraseña son obligatorios.");
            }

            var usuario = await _usuarioRepository.ObtenerPorCorreoAsync(request.Correo, cancellationToken);
            if (usuario is null)
            {
                _logger.LogWarning("Login failed for {Correo}: usuario no encontrado", request.Correo);
                return Result<LoginResponseDto>.Failure("Credenciales incorrectas.");
            }

            if (usuario.Estado != EstadoUsuario.Activo)
            {
                _logger.LogWarning("Login failed for {Correo}: usuario inactivo", request.Correo);
                return Result<LoginResponseDto>.Failure("Usuario inactivo.");
            }

            if (!_passwordHasher.VerificarPassword(request.Password, usuario.PasswordHash))
            {
                _logger.LogWarning("Login failed for {Correo}: contraseña incorrecta", request.Correo);
                return Result<LoginResponseDto>.Failure("Credenciales incorrectas.");
            }

            var accessToken = _jwtTokenGenerator.GenerarToken(usuario);
            var refreshToken = Guid.NewGuid().ToString();

            var response = new LoginResponseDto
            {
                IdUsuario = usuario.IdUsuario,
                Correo = usuario.CorreoElectronico,
                TipoAcceso = usuario.TipoAcceso.ToString(),
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };

            return Result<LoginResponseDto>.SuccessResult(response);
        }

        public Task<LoginResponseDto?> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            // La lógica de refresh token dependerá del almacenamiento elegido.
            // Se devuelve null como marcador hasta que se implemente.
            return Task.FromResult<LoginResponseDto?>(null);
        }
    }
}
