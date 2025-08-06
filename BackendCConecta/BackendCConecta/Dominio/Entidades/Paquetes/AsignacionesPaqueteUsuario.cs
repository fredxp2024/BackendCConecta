using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Paquetes;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Paquetes;

public partial class AsignacionesPaqueteUsuario
{
    public int IdAsignacion { get; set; }

    public int IdPaquete { get; set; }

    public int IdDatosUsuario { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public int? PublicacionesUsadas { get; set; }

    public string? EstadoAsignacion { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<DetallePublicacionPaquete> DetallePublicacionPaquetes { get; set; } = new List<DetallePublicacionPaquete>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;

    public virtual PaquetesPromocional IdPaqueteNavigation { get; set; } = null!;

    public virtual ICollection<PagosPaquetePromocional> PagosPaquetePromocionals { get; set; } = new List<PagosPaquetePromocional>();
}
