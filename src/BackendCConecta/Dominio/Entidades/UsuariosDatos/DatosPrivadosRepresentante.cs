using System;
using System.Collections.Generic;
using BackendCConecta.Dominio.Entidades.Representantes;

namespace BackendCConecta.Dominio.Entidades.UsuariosDatos;

public partial class DatosPrivadosRepresentante
{
    public int IdDatoPrivado { get; set; }

    public int IdRepresentante { get; set; }

    public string? DireccionResidencia { get; set; }

    public string? TelefonoPersonal { get; set; }

    public string? CorreoPersonal { get; set; }

    public string? DocumentoIdentidad { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public virtual Representante IdRepresentanteNavigation { get; set; } = null!;
}
