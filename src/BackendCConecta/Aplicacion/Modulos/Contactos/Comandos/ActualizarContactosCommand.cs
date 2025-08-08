using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

public class ActualizarContactosCommand : IRequest<bool>
{
    public int IdContacto { get; set; }
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
}
