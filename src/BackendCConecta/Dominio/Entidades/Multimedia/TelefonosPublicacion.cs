using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class TelefonosPublicacion
{
    public int IdTelefono { get; set; }

    public int IdPublicacion { get; set; }

    public string? TipoTelefono { get; set; }

    public string? Numero { get; set; }

    public string? Observacion { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
