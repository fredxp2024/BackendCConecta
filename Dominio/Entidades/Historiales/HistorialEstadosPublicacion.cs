using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.Staff;

namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialEstadosPublicacion
{
    public int IdHistorialEstado { get; set; }

    public int IdPublicacion { get; set; }

    public string? EstadoAnterior { get; set; }

    public string EstadoNuevo { get; set; } = null!;

    public string? MotivoCambio { get; set; }

    public int? IdStaff { get; set; }

    public DateTime? FechaCambio { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual StaffAdministrativo? IdStaffNavigation { get; set; }
}
