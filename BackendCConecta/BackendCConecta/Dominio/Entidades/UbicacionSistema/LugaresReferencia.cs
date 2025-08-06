using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.UbicacionSistema;

public partial class LugaresReferencia
{
    public int IdLugar { get; set; }

    public string NombreLugar { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? IdUbicacion { get; set; }

    public string? ReferenciaMapa { get; set; }

    public bool? VisibleEnPortal { get; set; }

    public virtual UbicacionesSistema? IdUbicacionNavigation { get; set; }

    public virtual ICollection<Publicacion> IdPublicacions { get; set; } = new List<Publicacion>();
}
