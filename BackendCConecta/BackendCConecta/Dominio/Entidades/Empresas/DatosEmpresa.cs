using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
namespace BackendCConecta.Dominio.Entidades.Empresas;

public partial class DatosEmpresa
{
    public int IdDatosUsuario { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Ruc { get; set; }

    public string? PaginaWeb { get; set; }

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;
}
