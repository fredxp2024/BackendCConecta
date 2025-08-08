using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;

/// <summary>
/// Define operations related to campaign management.
/// </summary>
public interface ICampaniaService
{
    /// <summary>
    /// Persists a new campaign.
    /// </summary>
    /// <param name="campania">Information for the campaign to create.</param>
    /// <returns>The identifier of the created campaign.</returns>
    Task<int> CrearCampaniaAsync(CampaniaDTO campania);

    /// <summary>
    /// Retrieves all campaigns registered in the system.
    /// </summary>
    /// <returns>A read only collection of campaigns.</returns>
    Task<IReadOnlyList<CampaniaDTO>> ObtenerCampaniasAsync();
}

