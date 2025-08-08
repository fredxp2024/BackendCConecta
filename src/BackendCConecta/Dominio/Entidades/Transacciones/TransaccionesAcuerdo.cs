using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Acuerdos;

namespace BackendCConecta.Dominio.Entidades.Transacciones;

public partial class TransaccionesAcuerdo
{
    public int IdTransaccionAcuerdo { get; set; }

    public int IdAcuerdo { get; set; }

    public decimal MontoPagado { get; set; }

    public string? MetodoPago { get; set; }

    public string? EstadoPago { get; set; }

    public string? ReferenciaPago { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<CapturasTransaccionAcuerdo> CapturasTransaccionAcuerdos { get; set; } = new List<CapturasTransaccionAcuerdo>();

    public virtual AcuerdosComercial IdAcuerdoNavigation { get; set; } = null!;
}
