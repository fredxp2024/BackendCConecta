using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Publicaciones;

namespace BackendCConecta.Dominio.Entidades.Colaboradores;

public partial class ParticipacionColaborador
{
    public int IdParticipacion { get; set; }

    public int IdColaborador { get; set; }

    public int IdPublicacion { get; set; }

    public string TipoParticipacion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaParticipacion { get; set; }

    public virtual Colaborador IdColaboradorNavigation { get; set; } = null!;

    public virtual Publicacion IdPublicacionNavigation { get; set; } = null!;
}
