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

    public async Task<bool> Handle(EliminarAcuerdoComercialCommand request, CancellationToken cancellationToken)
    {
        return await _service.EliminarAsync(request.Id);
    }
}
