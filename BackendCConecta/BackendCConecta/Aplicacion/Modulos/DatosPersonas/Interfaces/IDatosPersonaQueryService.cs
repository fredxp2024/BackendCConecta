using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;

public interface IDatosPersonaQueryService
{
    Task<DatosPersonaDto?> ObtenerPorIdAsync(int idDatosUsuario);
    Task<IEnumerable<DatosPersonaDto>> ListarAsync();
}
