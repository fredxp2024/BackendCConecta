using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;

/// <summary>
/// Defines operations related to modifying campaign data.
/// </summary>
public interface ICampaniaCommandService
{
    /// <summary>
    /// Persists a new campaign.
    /// </summary>
    /// <param name="campania">Information for the campaign to create.</param>
    /// <returns>The identifier of the created campaign.</returns>
    Task<int> CrearCampaniaAsync(CampaniaDTO campania);
}

