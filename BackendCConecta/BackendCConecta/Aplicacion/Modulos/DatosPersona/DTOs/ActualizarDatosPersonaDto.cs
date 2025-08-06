namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

public class ActualizarDatosPersonaDto
{
    public string Nombres { get; set; } = null!;
    public string ApellidoPaterno { get; set; } = null!;
    public string? ApellidoMaterno { get; set; }
    public string? Dni { get; set; }
}
