using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
namespace BackendCConecta.Dominio.Entidades.Paquetes;

public partial class PaquetesPromocional
{
    public int IdPaquete { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int PublicacionesIncluidas { get; set; }

    public int DuracionDias { get; set; }

    public decimal PrecioTotal { get; set; }

    public int IdStaff { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<AsignacionesPaqueteUsuario> AsignacionesPaqueteUsuarios { get; set; } = new List<AsignacionesPaqueteUsuario>();

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;
}
