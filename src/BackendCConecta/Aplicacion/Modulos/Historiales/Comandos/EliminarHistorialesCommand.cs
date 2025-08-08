using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Comandos
{
    public class EliminarHistorialesCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
