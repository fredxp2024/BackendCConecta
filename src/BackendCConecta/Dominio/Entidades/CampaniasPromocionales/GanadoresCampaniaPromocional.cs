using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

public partial class GanadoresCampaniaPromocional
{
    public int IdGanador { get; set; }

    public int IdCampania { get; set; }

    public int IdParticipante { get; set; }

    public int? IdPremio { get; set; }

    public DateOnly? FechaGanador { get; set; }

    public string? Observaciones { get; set; }

    public virtual CampaniasPromocional IdCampaniaNavigation { get; set; } = null!;

    public virtual ParticipantesCampaniaPromocional IdParticipanteNavigation { get; set; } = null!;

    public virtual PremiosCampaniaPromocional? IdPremioNavigation { get; set; }
}
