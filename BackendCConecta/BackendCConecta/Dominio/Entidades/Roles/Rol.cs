using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Staff;

namespace BackendCConecta.Dominio.Entidades.Roles;

public partial class Rol
{
    public int IdRol { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Grupo { get; set; }

    public string? Uso { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<AccionesAdministrador> AccionesAdministradors { get; set; } = new List<AccionesAdministrador>();

    public virtual ICollection<UsuariosRol> UsuariosRoles { get; set; } = new List<UsuariosRol>();
}
