using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class MultimediaPublicacion
{
    public int IdMultimedia { get; set; }

    public int IdPublicacion { get; set; }

    public string? TipoMedia { get; set; }

    public string Url { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? Orden { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public DateTime? FechaSubida { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
