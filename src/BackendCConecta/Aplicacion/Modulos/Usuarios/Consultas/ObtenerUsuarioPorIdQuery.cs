using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas
{
    public class ObtenerUsuarioPorIdQuery : IRequest<UsuarioDto>
    {
        public int IdUsuario { get; }

        public ObtenerUsuarioPorIdQuery(int idUsuario)
        {
            IdUsuario = idUsuario;
        }
    }
}
