using MediatR;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Handlers;

public class CambiarEstadoContactosHandler : IRequestHandler<CambiarEstadoContactosCommand, bool>
{
    private readonly IContactosService _contactosService;

    public CambiarEstadoContactosHandler(IContactosService contactosService)
    {
        _contactosService = contactosService;
    }

    public Task<bool> Handle(CambiarEstadoContactosCommand request, CancellationToken cancellationToken)
    {
        return _contactosService.CambiarEstadoContactoAsync(request.IdContacto, request.Estado);
    }
}
