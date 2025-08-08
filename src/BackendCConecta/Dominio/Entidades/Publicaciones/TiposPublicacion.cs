using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class TiposPublicacion
{
    public int IdTipo { get; set; }

    public string NombreTipo { get; set; } = null!;

    public virtual ICollection<CategoriasPublicacion> CategoriasPublicacions { get; set; } = new List<CategoriasPublicacion>();

    public virtual ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();

    public virtual ICollection<TarifasAcuerdosComercial> TarifasAcuerdosComerciales { get; set; } = new List<TarifasAcuerdosComercial>();

    public virtual ICollection<TarifasPublicacion> TarifasPublicacions { get; set; } = new List<TarifasPublicacion>();
}
