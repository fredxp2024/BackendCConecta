using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos
{
    public class CambiarEstadoPaquetesCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
