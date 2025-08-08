using MediatR;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Handlers;

public class CrearContactosHandler : IRequestHandler<CrearContactosCommand, ContactosDto>
{
    private readonly IContactosService _contactosService;

    public CrearContactosHandler(IContactosService contactosService)
    {
        _contactosService = contactosService;
    }

    public Task<ContactosDto> Handle(CrearContactosCommand request, CancellationToken cancellationToken)
    {
        var dto = new CrearContactosDto(request.Nombre, request.Telefono, request.Correo);
        return _contactosService.CrearContactoAsync(dto);
    }
}
