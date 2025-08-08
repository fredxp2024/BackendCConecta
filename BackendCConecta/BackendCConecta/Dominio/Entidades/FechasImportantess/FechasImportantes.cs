using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Entidades.Colaboradores;


namespace BackendCConecta.Dominio.Entidades.FechasImportantess;
public partial class FechasImportantes
{
    public int IdFechaImportante { get; set; }

    public int? IdColaborador { get; set; }

    public int IdTipoFecha { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdUbicacion { get; set; }

    public int? IdStaff { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Colaborador? IdColaboradorNavigation { get; set; }

    public virtual StaffAdministrativo? IdStaffNavigation { get; set; }

    public virtual TiposFechaImportantes IdTipoFechaNavigation { get; set; } = null!;

    public virtual UbicacionSistema IdUbicacionNavigation { get; set; } = null!;
}
