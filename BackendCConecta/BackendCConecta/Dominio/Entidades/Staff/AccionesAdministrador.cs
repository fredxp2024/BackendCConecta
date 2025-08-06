using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Roles;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Staff;

public partial class AccionesAdministrador
{
    public int IdAccion { get; set; }

    public int IdStaff { get; set; }

    public int IdDatosUsuario { get; set; }

    public int IdRol { get; set; }

    public string? TipoAccion { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaAccion { get; set; }

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;
}
