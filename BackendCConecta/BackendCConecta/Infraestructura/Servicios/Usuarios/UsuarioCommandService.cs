using System;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Repositorios;

namespace BackendCConecta.Infraestructura.Servicios.Usuarios;

public class UsuarioCommandService : IUsuarioCommandService
{
    private readonly IUsuarioRepository _repository;
    private readonly IPasswordHasher _passwordHasher;

    public UsuarioCommandService(IUsuarioRepository repository, IPasswordHasher passwordHasher)
    {
        _repository = repository;
        _passwordHasher = passwordHasher;
    }

    public async Task<UsuarioDto> RegistrarUsuarioAsync(RegistrarUsuarioCommand request)
    {
        var entidad = new Usuario
        {
            Nombre = request.CorreoElectronico,
            CorreoElectronico = request.CorreoElectronico,
            PasswordHash = _passwordHasher.HashPassword(request.Password),
            MetodoAutenticacion = Enum.Parse<MetodoAutenticacion>(request.MetodoAutenticacion, true),
            TipoAcceso = Enum.Parse<TipoAcceso>(request.TipoAcceso, true),
            FechaRegistro = request.FechaRegistro,
            Estado = Enum.Parse<EstadoUsuario>(request.Estado ?? EstadoUsuario.Activo.ToString(), true)
        };

        await _repository.InsertarAsync(entidad);
        return MapToDto(entidad);
    }

    public async Task<UsuarioDto> ActualizarUsuarioAsync(ActualizarUsuarioCommand request)
    {
        var entidad = await _repository.ObtenerPorIdAsync(request.IdUsuario)
            ?? throw new InvalidOperationException("Usuario no encontrado");

        if (!string.IsNullOrEmpty(request.CorreoElectronico))
            entidad.CorreoElectronico = request.CorreoElectronico;
        if (!string.IsNullOrEmpty(request.Password))
            entidad.PasswordHash = _passwordHasher.HashPassword(request.Password);
        if (!string.IsNullOrEmpty(request.MetodoAutenticacion))
            entidad.MetodoAutenticacion = Enum.Parse<MetodoAutenticacion>(request.MetodoAutenticacion, true);
        if (!string.IsNullOrEmpty(request.TipoAcceso))
            entidad.TipoAcceso = Enum.Parse<TipoAcceso>(request.TipoAcceso, true);
        if (!string.IsNullOrEmpty(request.Estado))
            entidad.Estado = Enum.Parse<EstadoUsuario>(request.Estado, true);

        await _repository.ActualizarAsync(entidad);
        return MapToDto(entidad);
    }

    public async Task<bool> EliminarUsuarioAsync(int idUsuario)
    {
        var entidad = await _repository.ObtenerPorIdAsync(idUsuario)
            ?? throw new InvalidOperationException("Usuario no encontrado");
        await _repository.EliminarAsync(entidad);
        return true;
    }

    private static UsuarioDto MapToDto(Usuario usuario) => new()
    {
        IdUsuario = usuario.IdUsuario,
        CorreoElectronico = usuario.CorreoElectronico,
        MetodoAutenticacion = usuario.MetodoAutenticacion.ToString(),
        TipoAcceso = usuario.TipoAcceso.ToString(),
        Estado = usuario.Estado.ToString(),
        FechaRegistro = usuario.FechaRegistro
    };
}

