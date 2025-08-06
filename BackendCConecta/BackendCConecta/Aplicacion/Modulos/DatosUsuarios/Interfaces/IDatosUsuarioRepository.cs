namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;

using BackendCConecta.Dominio.Entidades;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

public interface IDatosUsuarioRepository
{
    Task<DatosUsuario> CrearAsync(DatosUsuario entidad, CancellationToken cancellationToken);
    Task<bool> ActualizarAsync(DatosUsuario entidad, CancellationToken cancellationToken);
    Task<bool> EliminarAsync(int idDatosUsuario, CancellationToken cancellationToken);
    Task<DatosUsuario?> ObtenerPorIdAsync(int idDatosUsuario, CancellationToken cancellationToken);
}
