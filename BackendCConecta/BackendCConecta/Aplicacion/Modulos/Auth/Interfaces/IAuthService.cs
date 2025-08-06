using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto> LoginAsync(LoginRequestDto request);
        Task<LoginResponseDto> RefreshTokenAsync(string refreshToken);
        Task<TokenUsuarioDto?> LoginAsync(string correoElectronico, string password, CancellationToken cancellationToken);

    }
}




