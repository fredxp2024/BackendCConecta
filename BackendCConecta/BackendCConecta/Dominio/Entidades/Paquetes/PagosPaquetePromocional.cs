using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Paquetes;

public partial class PagosPaquetePromocional
{
    public int IdPagoPaquete { get; set; }

    public int IdAsignacion { get; set; }

    public decimal? MontoPagado { get; set; }

    public string? MetodoPago { get; set; }

    public string? EstadoPago { get; set; }

    public string? ReferenciaPago { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? Observaciones { get; set; }

    public virtual AsignacionesPaqueteUsuario IdAsignacionNavigation { get; set; } = null!;
}
