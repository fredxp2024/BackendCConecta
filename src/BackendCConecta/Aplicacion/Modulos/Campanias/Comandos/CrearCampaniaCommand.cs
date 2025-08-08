using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;

/// <summary>
/// Command used to create a new campaign.
/// </summary>
public class CrearCampaniaCommand : IRequest<int>
{
    public string Titulo { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    public string TipoCampania { get; set; } = string.Empty;

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public string? Estado { get; set; }

    public int? IdUbicacion { get; set; }

    public int IdStaff { get; set; }
}

