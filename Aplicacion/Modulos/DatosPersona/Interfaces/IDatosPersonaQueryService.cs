using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

public interface IDatosPersonaQueryService
{
    Task<DatosPersonaDto?> ObtenerPorIdAsync(int idDatosUsuario);
    Task<IEnumerable<DatosPersonaDto>> ListarAsync();
}
