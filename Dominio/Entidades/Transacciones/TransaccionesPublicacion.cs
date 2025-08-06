using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.Publicaciones;


namespace BackendCConecta.Dominio.Entidades.Transacciones;

public partial class TransaccionesPublicacion
{
    public int IdTransaccion { get; set; }

    public int IdPublicacion { get; set; }

    public string TipoTransaccion { get; set; } = null!;

    public string? EstadoTransaccion { get; set; }

    public string? MetodoPago { get; set; }

    public string? ReferenciaPago { get; set; }

    public decimal MontoTotal { get; set; }

    public DateOnly FechaInicio { get; set; }

    public int DiasContratados { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CapturasTransaccionPublicacion> CapturasTransaccionPublicacions { get; set; } = new List<CapturasTransaccionPublicacion>();

    public virtual ICollection<HistorialEstadosTransaccion> HistorialEstadosTransaccions { get; set; } = new List<HistorialEstadosTransaccion>();

    public virtual ICollection<HistorialPublicacionFecha> HistorialPublicacionFechas { get; set; } = new List<HistorialPublicacionFecha>();

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual ICollection<PreciosPublicacion> PreciosPublicacions { get; set; } = new List<PreciosPublicacion>();
}
