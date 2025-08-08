
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;

public interface IDatosUsuarioQueryService
{
    Task<List<DatosUsuarioDto>> ListarAsync(CancellationToken cancellationToken);
    Task<DatosUsuarioDto?> ObtenerPorIdAsync(int idDatosUsuario, CancellationToken cancellationToken);
}
