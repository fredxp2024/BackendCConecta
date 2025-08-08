using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos
{
    public class EliminarMultimediaCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
