using System;
using System.Collections.Generic;

using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Dominio.Entidades.Staff;

namespace BackendCConecta.Dominio.Entidades.Representantes;

public partial class MetaGlobalRespaldo
{
    public int IdMeta { get; set; }

    public int IdCampania { get; set; }

    public string TipoCandidato { get; set; } = null!;

    public int ValorMaximoDetectado { get; set; }

    public int AjusteExtra { get; set; }

    public int MetaFinal { get; set; }

    public DateTime? FechaMeta { get; set; }

    public int IdStaff { get; set; }

    public string? Comentario { get; set; }

    public virtual Campania IdCampaniaNavigation { get; set; } = null!;

    public virtual StaffAdministrativo IdStaffNavigation { get; set; } = null!;
}
