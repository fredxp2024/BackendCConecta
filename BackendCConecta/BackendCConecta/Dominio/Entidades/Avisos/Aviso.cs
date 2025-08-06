using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Avisos;

public partial class Aviso
{
    public int IdAviso { get; set; }

    public int IdPublicacion { get; set; }

    public string? TipoAviso { get; set; }

    public string? Modalidad { get; set; }

    public string? Condiciones { get; set; }

    public bool? EsNegociable { get; set; }

    public string? FormaPago { get; set; }

    public DateTime? FechaDisponible { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
