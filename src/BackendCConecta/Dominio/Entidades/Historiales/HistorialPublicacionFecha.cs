using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Historiales;

public partial class HistorialPublicacionFecha
{
    public int IdHistorialFecha { get; set; }

    public int IdPublicacion { get; set; }

    public string TipoFecha { get; set; } = null!;

    public DateTime FechaAplicada { get; set; }

    public int? IdTransaccion { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual TransaccionesPublicacion? IdTransaccionNavigation { get; set; }
}
