using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Campanias;

public partial class CampaniasElectoral
{
    public int IdCampania { get; set; }

    public string NivelElectoral { get; set; } = null!;

    public virtual Campania IdCampaniaNavigation { get; set; } = null!;
}
