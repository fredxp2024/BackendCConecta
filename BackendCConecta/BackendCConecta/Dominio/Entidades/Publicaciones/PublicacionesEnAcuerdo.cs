using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Acuerdos;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class PublicacionesEnAcuerdo
{
    public int IdRelacion { get; set; }

    public int IdAcuerdo { get; set; }

    public int IdPublicacion { get; set; }

    public DateOnly? FechaUso { get; set; }

    public virtual AcuerdosComercial IdAcuerdoNavigation { get; set; } = null!;

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
