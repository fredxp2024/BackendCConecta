using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

public class CrearFechasImportantesCommand : IRequest<int>
{
    public string Titulo { get; set; } = string.Empty;
    public DateOnly Fecha { get; set; }
}
