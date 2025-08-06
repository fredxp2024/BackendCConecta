namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

public class CrearDatosPersonaDto
{
    public int IdDatosUsuario { get; set; }
    public string Nombres { get; set; } = null!;
    public string ApellidoPaterno { get; set; } = null!;
    public string? ApellidoMaterno { get; set; }
    public string? Dni { get; set; }
}
