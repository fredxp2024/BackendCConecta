using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Interfaces
{
    /// <summary>
    /// Servicio encargado de la autenticación de usuarios.
    /// </summary>
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto request, CancellationToken cancellationToken = default);
        Task<LoginResponseDto?> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default);
    }
}
