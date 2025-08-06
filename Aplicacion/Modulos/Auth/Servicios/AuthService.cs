using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Auth.DTOs;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Repositorios;

namespace BackendCConecta.Aplicacion.Modulos.Auth.Servicios;

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

    public async Task<TokenUsuarioDto?> LoginAsync(string correoElectronico, string password, CancellationToken cancellationToken)
    {
        var usuario = await _usuarioRepository.ObtenerPorCorreoAsync(correoElectronico, cancellationToken);

        if (usuario is null)
            return null;

        if (usuario.Estado?.ToLower() != "activo")
            return null;

        var passwordValido = _passwordHasher.Verificar(usuario.PasswordHash, password);

        if (!passwordValido)
            return null;

        var token = _jwtTokenGenerator.GenerarToken(usuario);

        return new TokenUsuarioDto
        {
            IdUsuario = usuario.IdUsuario,
            CorreoElectronico = usuario.CorreoElectronico,
            Token = token,
            TipoAcceso = usuario.TipoAcceso
        };
    }
}
