namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.DTOs;

public class FechasImportantesDto
{
    public int IdFechaImportante { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public DateOnly Fecha { get; set; }
    public bool Activo { get; set; }
}
