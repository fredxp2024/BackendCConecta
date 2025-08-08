using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Campanias;

namespace BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

public partial class CampaniasPromocional
{
    public int IdCampania { get; set; }

    public string TipoPromocional { get; set; } = null!;

    public virtual ICollection<GanadoresCampaniaPromocional> GanadoresCampaniaPromocionals { get; set; } = new List<GanadoresCampaniaPromocional>();

    public virtual Campania IdCampaniaNavigation { get; set; } = null!;

    public virtual ICollection<ParticipantesCampaniaPromocional> ParticipantesCampaniaPromocionals { get; set; } = new List<ParticipantesCampaniaPromocional>();

    public virtual ICollection<PremiosCampaniaPromocional> PremiosCampaniaPromocionals { get; set; } = new List<PremiosCampaniaPromocional>();
}
