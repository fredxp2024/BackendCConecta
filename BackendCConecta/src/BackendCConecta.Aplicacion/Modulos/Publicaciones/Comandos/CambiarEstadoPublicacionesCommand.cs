using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos
{
    public class CambiarEstadoPublicacionesCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
    }
}
