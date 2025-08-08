using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.CampaniasPromocionales;

public partial class ParticipantesCampaniaPromocional
{
    public int IdParticipante { get; set; }

    public int IdCampania { get; set; }

    public string Nombres { get; set; } = null!;

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Dni { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string CodigoTicket { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<GanadoresCampaniaPromocional> GanadoresCampaniaPromocionals { get; set; } = new List<GanadoresCampaniaPromocional>();

    public virtual CampaniasPromocional IdCampaniaNavigation { get; set; } = null!;
}
