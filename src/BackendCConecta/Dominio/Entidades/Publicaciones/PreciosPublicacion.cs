using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class PreciosPublicacion
{
    public int IdPrecio { get; set; }

    public int IdPublicacion { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal Monto { get; set; }

    public string? Descripcion { get; set; }

    public int? IdTransaccion { get; set; }

    public int? IdTarifa { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual TarifasPublicacion? IdTarifaNavigation { get; set; }

    public virtual TransaccionesPublicacion? IdTransaccionNavigation { get; set; }
}
