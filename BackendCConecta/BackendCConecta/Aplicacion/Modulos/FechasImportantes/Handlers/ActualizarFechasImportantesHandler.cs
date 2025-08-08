using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Handlers;

public class ActualizarFechasImportantesHandler : IRequestHandler<ActualizarFechasImportantesCommand, bool>
{
    private readonly IFechasImportantesService _service;

    public ActualizarFechasImportantesHandler(IFechasImportantesService service)
    {
        _service = service;
    }

    public Task<bool> Handle(ActualizarFechasImportantesCommand request, CancellationToken cancellationToken)
    {
        return _service.ActualizarAsync(request);
    }
}
