using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos
{
    public class CambiarEstadoMultimediaCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
