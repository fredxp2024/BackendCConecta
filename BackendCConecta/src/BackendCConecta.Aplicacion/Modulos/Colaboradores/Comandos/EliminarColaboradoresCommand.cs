using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos
{
    public class EliminarColaboradoresCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
