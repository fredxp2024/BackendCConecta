using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.Transacciones;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;


namespace BackendCConecta.Dominio.Entidades.Acuerdos;

public partial class AcuerdosComercial
{
    public int IdAcuerdo { get; set; }

    public int IdDatosUsuario { get; set; }

    public int IdTarifaAcuerdo { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public int PublicacionesDisponibles { get; set; }

    public int? DiasGracia { get; set; }

    public string? EstadoAcuerdo { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<HistorialModificacionesAcuerdo> HistorialModificacionesAcuerdos { get; set; } = new List<HistorialModificacionesAcuerdo>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual TarifasAcuerdosComercial IdTarifaAcuerdoNavigation { get; set; } = null!;

    public virtual ICollection<PublicacionesEnAcuerdo> PublicacionesEnAcuerdos { get; set; } = new List<PublicacionesEnAcuerdo>();

    public virtual ICollection<TransaccionesAcuerdo> TransaccionesAcuerdos { get; set; } = new List<TransaccionesAcuerdo>();
}
