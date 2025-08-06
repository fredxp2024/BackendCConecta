using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Representantes;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Usuarios;
public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string MetodoAutenticacion { get; set; } = null!;

    public string TipoAcceso { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }

    public virtual DatosUsuario? DatosUsuario { get; set; }

    public virtual ICollection<MeGustaRepresentante> MeGustaRepresentantes { get; set; } = new List<MeGustaRepresentante>();
}
