using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Comandos
{
    public class CambiarEstadoInteresesCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
