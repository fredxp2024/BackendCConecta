using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class CategoriasPublicacion
{
    public int IdCategoria { get; set; }

    public int IdTipo { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public virtual TiposPublicacion IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<SubcategoriasPublicacion> SubcategoriasPublicacions { get; set; } = new List<SubcategoriasPublicacion>();
}
