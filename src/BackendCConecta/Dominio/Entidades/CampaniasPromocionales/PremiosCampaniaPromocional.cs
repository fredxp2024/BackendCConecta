using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

public partial class PremiosCampaniaPromocional
{
    public int IdPremio { get; set; }

    public int IdCampania { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? OrdenEntrega { get; set; }

    public virtual ICollection<GanadoresCampaniaPromocional> GanadoresCampaniaPromocionals { get; set; } = new List<GanadoresCampaniaPromocional>();

    public virtual CampaniasPromocional IdCampaniaNavigation { get; set; } = null!;
}
