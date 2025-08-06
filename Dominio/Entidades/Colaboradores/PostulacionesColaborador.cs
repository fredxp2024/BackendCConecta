using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Colaboradores;

public partial class PostulacionesColaborador
{
    public int IdPostulacion { get; set; }

    public int IdDatosUsuario { get; set; }

    public string? DescripcionPostulacion { get; set; }

    public string EstadoPostulacion { get; set; } = null!;

    public DateTime? FechaPostulacion { get; set; }

    public virtual ICollection<HistorialPostulacionesColaborador> HistorialPostulacionesColaboradors { get; set; } = new List<HistorialPostulacionesColaborador>();

    public virtual DatosUsuario IdDatosUsuarioNavigation { get; set; } = null!;
}
