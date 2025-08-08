using MediatR;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Handlers;

public class ActualizarContactosHandler : IRequestHandler<ActualizarContactosCommand, bool>
{
    private readonly IContactosService _contactosService;

    public ActualizarContactosHandler(IContactosService contactosService)
    {
        _contactosService = contactosService;
    }

    public Task<bool> Handle(ActualizarContactosCommand request, CancellationToken cancellationToken)
    {
        var dto = new ActualizarContactosDto(request.IdContacto, request.Nombre, request.Telefono, request.Correo);
        return _contactosService.ActualizarContactoAsync(dto);
    }
}
