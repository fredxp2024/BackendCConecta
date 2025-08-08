using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Handlers;

public class EliminarFechasImportantesHandler : IRequestHandler<EliminarFechasImportantesCommand, bool>
{
    private readonly IFechasImportantesService _service;

    public EliminarFechasImportantesHandler(IFechasImportantesService service)
    {
        _service = service;
    }

    public Task<bool> Handle(EliminarFechasImportantesCommand request, CancellationToken cancellationToken)
    {
        return _service.EliminarAsync(request.IdFechaImportante);
    }
}
