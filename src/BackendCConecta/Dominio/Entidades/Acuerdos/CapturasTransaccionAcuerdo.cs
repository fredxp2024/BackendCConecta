using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Transacciones;

namespace BackendCConecta.Dominio.Entidades.Acuerdos;

public partial class CapturasTransaccionAcuerdo
{
    public int IdCaptura { get; set; }

    public int IdTransaccionAcuerdo { get; set; }

    public string? TipoCaptura { get; set; }

    public string? Contenido { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaSubida { get; set; }

    public virtual TransaccionesAcuerdo IdTransaccionAcuerdoNavigation { get; set; } = null!;
}
