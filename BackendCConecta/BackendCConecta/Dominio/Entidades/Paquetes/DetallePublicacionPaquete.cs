using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Paquetes;

public partial class DetallePublicacionPaquete
{
    public int IdDetalle { get; set; }

    public int IdAsignacion { get; set; }

    public int IdPublicacion { get; set; }

    public DateOnly? FechaUso { get; set; }

    public virtual AsignacionesPaqueteUsuario IdAsignacionNavigation { get; set; } = null!;

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
