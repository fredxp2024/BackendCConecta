using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Comandos
{
    public class CambiarEstadoHistorialesCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
