using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Campanias;

namespace BackendCConecta.Dominio.Entidades.Representantes;

public partial class RepresentantesCampania
{
    public int Id { get; set; }

    public int IdRepresentante { get; set; }

    public int IdCampania { get; set; }

    public virtual Campania IdCampaniaNavigation { get; set; } = null!;

    public virtual Representante IdRepresentanteNavigation { get; set; } = null!;
}
