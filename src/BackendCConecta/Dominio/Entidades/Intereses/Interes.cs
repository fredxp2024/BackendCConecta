using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Intereses;

public partial class Interes
{
    public int IdInteres { get; set; }

    public string NombreInteres { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<InteresesPublicacion> InteresesPublicacions { get; set; } = new List<InteresesPublicacion>();

    public virtual ICollection<InteresesUsuario> InteresesUsuarios { get; set; } = new List<InteresesUsuario>();
}
