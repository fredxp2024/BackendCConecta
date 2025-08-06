using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Historiales;
using BackendCConecta.Dominio.Entidades.Publicaciones;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;

namespace BackendCConecta.Dominio.Entidades.Representantes;

public partial class Representante
{
    public int IdRepresentante { get; set; }

    public int IdPublicacion { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Profesion { get; set; }

    public string? LugarTrabajo { get; set; }

    public string? LemaPersonal { get; set; }

    public string TipoCandidato { get; set; } = null!;

    public bool? VisiblePublicamente { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual DatosPrivadosRepresentante? DatosPrivadosRepresentante { get; set; }

    public virtual ICollection<HistorialCargosRepresentante> HistorialCargosRepresentantes { get; set; } = new List<HistorialCargosRepresentante>();

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;

    public virtual ICollection<MeGustaRepresentante> MeGustaRepresentantes { get; set; } = new List<MeGustaRepresentante>();

    public virtual ICollection<RepresentantesCampania> RepresentantesCampania { get; set; } = new List<RepresentantesCampania>();
}
