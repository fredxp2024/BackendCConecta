using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class LinksMultimedia
{
    public int IdLink { get; set; }

    public int IdPublicacion { get; set; }

    public int IdTipo { get; set; }

    public string Url { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual TiposLinkMultimedia IdTipoNavigation { get; set; } = null!;
}
