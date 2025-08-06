using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Negocios;

public partial class Negocio
{
    public int IdNegocio { get; set; }

    public int IdPublicacion { get; set; }

    public string NombreNegocio { get; set; } = null!;

    public string? TipoNegocio { get; set; }

    public string? DescripcionServicio { get; set; }

    public string? HorarioAtencion { get; set; }

    public string? PaginaWeb { get; set; }

    public bool? DeliveryDisponible { get; set; }

    public string? FormatoVenta { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
