using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

public class CambiarEstadoFechasImportantesCommand : IRequest<bool>
{
    public int IdFechaImportante { get; set; }
    public bool Activo { get; set; }
}
