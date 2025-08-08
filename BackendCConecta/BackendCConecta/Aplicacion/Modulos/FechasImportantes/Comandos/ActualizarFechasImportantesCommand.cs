using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

public class ActualizarFechasImportantesCommand : IRequest<bool>
{
    public int IdFechaImportante { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public DateOnly Fecha { get; set; }
}
