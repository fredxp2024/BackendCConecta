using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Eventos;

public partial class Evento
{
    public int IdEvento { get; set; }

    public int IdPublicacion { get; set; }

    public string TipoEvento { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Lugar { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
