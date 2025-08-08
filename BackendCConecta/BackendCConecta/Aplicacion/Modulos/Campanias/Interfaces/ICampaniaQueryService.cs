using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;

/// <summary>
/// Defines operations related to retrieving campaign data.
/// </summary>
public interface ICampaniaQueryService
{
    /// <summary>
    /// Retrieves all campaigns registered in the system.
    /// </summary>
    /// <returns>A read only collection of campaigns.</returns>
    Task<IReadOnlyList<CampaniaDTO>> ObtenerCampaniasAsync();
}

