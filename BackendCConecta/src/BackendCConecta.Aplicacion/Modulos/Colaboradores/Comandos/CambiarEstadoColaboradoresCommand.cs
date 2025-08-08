using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos
{
    public class CambiarEstadoColaboradoresCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
