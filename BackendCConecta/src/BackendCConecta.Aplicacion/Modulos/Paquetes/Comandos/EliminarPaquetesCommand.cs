using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos
{
    public class EliminarPaquetesCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
