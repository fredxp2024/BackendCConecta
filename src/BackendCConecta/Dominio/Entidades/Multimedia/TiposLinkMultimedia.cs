using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class TiposLinkMultimedia
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<LinksMultimedia> LinksMultimedia { get; set; } = new List<LinksMultimedia>();
}
