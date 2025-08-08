using MediatR;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Handlers;

public class EliminarContactosHandler : IRequestHandler<EliminarContactosCommand, bool>
{
    private readonly IContactosService _contactosService;

    public EliminarContactosHandler(IContactosService contactosService)
    {
        _contactosService = contactosService;
    }

    public Task<bool> Handle(EliminarContactosCommand request, CancellationToken cancellationToken)
    {
        return _contactosService.EliminarContactoAsync(request.IdContacto);
    }
}
