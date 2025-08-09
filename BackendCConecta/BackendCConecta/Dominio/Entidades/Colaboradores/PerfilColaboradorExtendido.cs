using System;
using System.Collections.Generic;

namespace BackendCConecta.Dominio.Entidades.Colaboradores;

public partial class PerfilColaboradorExtendido
{
    public int IdPerfil { get; set; }

    public int IdColaborador { get; set; }

    public string? ResumenPersonal { get; set; }

    public string? CualidadesLiderazgo { get; set; }

    public string? EnlacesRedes { get; set; }

    public string? MensajePromocional { get; set; }

    public virtual Colaborador IdColaboradorNavigation { get; set; } = null!;
}
