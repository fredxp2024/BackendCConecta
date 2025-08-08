using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Dominio.Entidades.Staff;

namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialModificacionesAcuerdo
{
    public int IdHistorial { get; set; }

    public int IdAcuerdo { get; set; }

    public string CampoModificado { get; set; } = null!;

    public string? ValorAnterior { get; set; }

    public string? ValorNuevo { get; set; }

    public string? Motivo { get; set; }

    public int? IdStaff { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual AcuerdosComercial IdAcuerdoNavigation { get; set; } = null!;

    public virtual StaffAdministrativo? IdStaffNavigation { get; set; }
}
