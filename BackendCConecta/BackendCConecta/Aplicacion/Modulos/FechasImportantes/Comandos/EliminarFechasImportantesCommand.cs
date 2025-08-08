using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

public class EliminarFechasImportantesCommand : IRequest<bool>
{
    public int IdFechaImportante { get; set; }
}
