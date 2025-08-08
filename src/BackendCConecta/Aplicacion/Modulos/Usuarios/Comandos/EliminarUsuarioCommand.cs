using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos
{
    public class EliminarUsuarioCommand : IRequest<bool>
    {
        public int IdUsuario { get; set; }
    }
}
