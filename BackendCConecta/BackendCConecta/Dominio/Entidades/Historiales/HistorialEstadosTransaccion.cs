using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;

using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialEstadosTransaccion
{
    public int IdHistorialEstado { get; set; }

    public int IdTransaccion { get; set; }

    public string? EstadoAnterior { get; set; }

    public string EstadoNuevo { get; set; } = null!;

    public string? MotivoCambio { get; set; }

    public int? IdStaff { get; set; }

    public DateTime? FechaCambio { get; set; }

    public virtual StaffAdministrativo? IdStaffNavigation { get; set; }

    public virtual TransaccionesPublicacion IdTransaccionNavigation { get; set; } = null!;
}
