using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Usuario;

namespace BackendCConecta.Dominio.Entidades.Representantes;

public partial class MeGustaRepresentante
{
    public int IdClick { get; set; }

    public int IdRepresentante { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FechaClick { get; set; }

    public virtual Representante IdRepresentanteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
