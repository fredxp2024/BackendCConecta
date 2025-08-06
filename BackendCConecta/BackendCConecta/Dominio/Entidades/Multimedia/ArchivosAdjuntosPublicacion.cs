using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class ArchivosAdjuntosPublicacion
{
    public int IdArchivo { get; set; }

    public int IdPublicacion { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Extension { get; set; }

    public string Url { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaSubida { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
