using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

public class CambiarEstadoContactosCommand : IRequest<bool>
{
    public int IdContacto { get; set; }
    public string Estado { get; set; } = null!;
}
