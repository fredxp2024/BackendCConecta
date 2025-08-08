using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;
namespace BackendCConecta.Dominio.Entidades.Colaboradores;

public partial class ReconocimientosColaborador
{
    public int IdReconocimiento { get; set; }

    public int IdColaborador { get; set; }

    public int IdStaff { get; set; }

    public string? TituloReconocimiento { get; set; }

    public string? Descripcion { get; set; }

    public string? TipoReconocimiento { get; set; }

    public string? UrlConstancia { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public DateOnly? FechaReconocimiento { get; set; }

    public virtual Colaborador IdColaboradorNavigation { get; set; } = null!;

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;
}
