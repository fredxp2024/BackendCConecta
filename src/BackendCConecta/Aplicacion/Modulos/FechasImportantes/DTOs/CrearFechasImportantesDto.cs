namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.DTOs;

public class CrearFechasImportantesDto
{
    public string Titulo { get; set; } = string.Empty;
    public DateOnly Fecha { get; set; }
}
