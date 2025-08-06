using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Empresas;

public partial class DatosPersona
{
    public int IdDatosUsuario { get; set; }

    public string Nombres { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string? Dni { get; set; }

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;
}
