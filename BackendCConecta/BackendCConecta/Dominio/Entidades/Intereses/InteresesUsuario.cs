using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
namespace BackendCConecta.Dominio.Entidades.Intereses;

public partial class InteresesUsuario
{
    public int IdDatosUsuario { get; set; }

    public int IdInteres { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual Interes IdInteresNavigation { get; set; } = null!;
}
