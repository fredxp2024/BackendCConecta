using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Colaboradores;
using BackendCConecta.Dominio.Entidades.Staff;
namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialPostulacionesColaborador
{
    public int IdHistorial { get; set; }

    public int IdPostulacion { get; set; }

    public int IdStaff { get; set; }

    public string? NuevoEstado { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaRevision { get; set; }

    public virtual PostulacionesColaborador IdPostulacionNavigation { get; set; } = null!;

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;
}
