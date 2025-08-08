using MediatR;
using BackendCConecta.Aplicacion.Modulos.Contactos.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

public class CrearContactosCommand : IRequest<ContactosDto>
{
    public string Nombre { get; set; } = null!;
    public string Telefono { get; set; } = null!;
    public string Correo { get; set; } = null!;
}
