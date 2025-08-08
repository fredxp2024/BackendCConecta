using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class EliminarAcuerdoHandler : IRequestHandler<EliminarAcuerdoComercialCommand, bool>
{
    private readonly IAcuerdoCommandService _service;

    public EliminarAcuerdoHandler(IAcuerdoCommandService service)
    {
        _service = service;
    }

    public Task<bool> Handle(EliminarAcuerdoComercialCommand request, CancellationToken cancellationToken)
    {
        return _service.EliminarAsync(request.Id);
    }
}
