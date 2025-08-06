using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class DetallesPublicacion
{
    public int IdDetalle { get; set; }

    public int IdPublicacion { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
