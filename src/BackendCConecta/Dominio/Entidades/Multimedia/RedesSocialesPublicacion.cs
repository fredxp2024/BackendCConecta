using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Multimedia;

public partial class RedesSocialesPublicacion
{
    public int IdRedSocial { get; set; }

    public int IdPublicacion { get; set; }

    public string? Plataforma { get; set; }

    public string? Url { get; set; }

    public string? DescripcionOpcional { get; set; }

    public bool? VisiblePublicamente { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
