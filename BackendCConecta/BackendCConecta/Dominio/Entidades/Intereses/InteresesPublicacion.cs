using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Intereses;

public partial class InteresesPublicacion
{
    public int IdPublicacion { get; set; }

    public int IdInteres { get; set; }

    public DateTime? FechaEtiquetado { get; set; }

    public virtual Interes IdInteresNavigation { get; set; } = null!;

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
