using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Roles;

public partial class UsuarioRol
{
    public int IdUsuarioRol { get; set; }

    public int IdDatosUsuario { get; set; }

    public int IdRol { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
