using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Handlers;

public class CrearFechasImportantesHandler : IRequestHandler<CrearFechasImportantesCommand, int>
{
    private readonly IFechasImportantesService _service;

    public CrearFechasImportantesHandler(IFechasImportantesService service)
    {
        _service = service;
    }

    public Task<int> Handle(CrearFechasImportantesCommand request, CancellationToken cancellationToken)
    {
        return _service.CrearAsync(request);
    }
}
