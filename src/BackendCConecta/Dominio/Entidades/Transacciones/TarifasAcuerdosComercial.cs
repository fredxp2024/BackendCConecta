using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Dominio.Entidades.Staff;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Transacciones;

public partial class TarifasAcuerdosComercial
{
    public int IdTarifaAcuerdo { get; set; }

    public int IdStaff { get; set; }

    public int IdTipo { get; set; }

    public string? Descripcion { get; set; }

    public int PublicacionesIncluidas { get; set; }

    public int DiasDuracion { get; set; }

    public decimal PrecioTotal { get; set; }

    public bool? Activa { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<AcuerdosComercial> AcuerdosComerciales { get; set; } = new List<AcuerdosComerciale>();

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;

    public virtual TiposPublicacion IdTipoNavigation { get; set; } = null!;
}
