using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Handlers;

public class CambiarEstadoFechasImportantesHandler : IRequestHandler<CambiarEstadoFechasImportantesCommand, bool>
{
    private readonly IFechasImportantesService _service;

    public CambiarEstadoFechasImportantesHandler(IFechasImportantesService service)
    {
        _service = service;
    }

    public Task<bool> Handle(CambiarEstadoFechasImportantesCommand request, CancellationToken cancellationToken)
    {
        return _service.CambiarEstadoAsync(request.IdFechaImportante, request.Activo);
    }
}
