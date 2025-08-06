using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Representantes;

namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialCargosRepresentante
{
    public int IdHistorial { get; set; }

    public int IdRepresentante { get; set; }

    public string? NombreCargo { get; set; }

    public string? Entidad { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? Descripcion { get; set; }

    public virtual Representante IdRepresentanteNavigation { get; set; } = null!;
}
