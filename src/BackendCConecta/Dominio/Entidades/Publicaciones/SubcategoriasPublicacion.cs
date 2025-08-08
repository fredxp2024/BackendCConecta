using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades;

public partial class SubcategoriasPublicacion
{
    public int IdSubcategoria { get; set; }

    public int IdCategoria { get; set; }

    public string NombreSubcategoria { get; set; } = null!;

    public virtual CategoriasPublicacion IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();
}
