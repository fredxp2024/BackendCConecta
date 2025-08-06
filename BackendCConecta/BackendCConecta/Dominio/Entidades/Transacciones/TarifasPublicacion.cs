using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Transacciones;

public partial class TarifasPublicacion
{
    public int IdTarifa { get; set; }

    public int IdStaff { get; set; }

    public int IdTipo { get; set; }

    public short AnioTarifa { get; set; }

    public byte MesTarifa { get; set; }

    public string? Descripcion { get; set; }

    public decimal TarifaPorDia { get; set; }

    public bool? PrimeraPublicacionGratis { get; set; }

    public bool? Activa { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;

    public virtual TiposPublicacion IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<PreciosPublicacion> PreciosPublicacions { get; set; } = new List<PreciosPublicacion>();
}
