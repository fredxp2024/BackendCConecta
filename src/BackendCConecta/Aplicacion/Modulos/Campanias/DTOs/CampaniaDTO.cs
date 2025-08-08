namespace BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;

/// <summary>
/// Data transfer object representing a campaign.
/// </summary>
public class CampaniaDTO
{
    public int IdCampania { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    public string TipoCampania { get; set; } = string.Empty;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public string? Estado { get; set; }

    public int? IdUbicacion { get; set; }

    public int IdStaff { get; set; }
}

