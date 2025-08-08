using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Contactos;

public partial class ContactosAdicionalesPublicacion
{
    public int IdContacto { get; set; }

    public int IdPublicacion { get; set; }

    public string? TipoContacto { get; set; }

    public string? ValorContacto { get; set; }

    public string? Observacion { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
