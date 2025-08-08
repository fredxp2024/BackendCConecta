using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

public class EliminarContactosCommand : IRequest<bool>
{
    public int IdContacto { get; set; }
}
