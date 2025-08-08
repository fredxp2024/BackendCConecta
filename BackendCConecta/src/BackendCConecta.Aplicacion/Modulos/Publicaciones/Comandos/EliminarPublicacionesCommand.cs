using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos
{
    public class EliminarPublicacionesCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
