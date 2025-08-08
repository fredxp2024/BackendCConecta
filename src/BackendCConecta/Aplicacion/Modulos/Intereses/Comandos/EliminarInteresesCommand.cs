using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Comandos
{
    public class EliminarInteresesCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
