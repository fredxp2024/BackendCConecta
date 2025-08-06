using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Publicaciones;

public partial class CapturasTransaccionPublicacion
{
    public int IdCaptura { get; set; }

    public int IdTransaccion { get; set; }

    public string? TipoCaptura { get; set; }

    public string Contenido { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaSubida { get; set; }

    public virtual TransaccionesPublicacion IdTransaccionNavigation { get; set; } = null!;
}
