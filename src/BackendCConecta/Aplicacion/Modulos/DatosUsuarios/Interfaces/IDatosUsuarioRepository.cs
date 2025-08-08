namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;

using BackendCConecta.Dominio.Entidades;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using System.Collections.Generic;

public interface IDatosUsuarioRepository
{
    Task<DatosUsuario> CrearAsync(DatosUsuario entidad, CancellationToken cancellationToken);
    Task<bool> ActualizarAsync(DatosUsuario entidad, CancellationToken cancellationToken);
    Task<bool> EliminarAsync(int idDatosUsuario, CancellationToken cancellationToken);
    Task<List<DatosUsuario>> ListarAsync(CancellationToken cancellationToken);
    Task<DatosUsuario?> ObtenerAsync(int? idDatosUsuario, int? idUsuario, CancellationToken cancellationToken);
}
