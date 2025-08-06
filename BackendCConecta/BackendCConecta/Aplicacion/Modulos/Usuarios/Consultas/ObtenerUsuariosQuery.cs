using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas
{
    public class ObtenerUsuariosQuery : IRequest<UsuarioDto>
    {
        public int IdUsuario { get; set; }

        public ObtenerUsuariosQuery(int idUsuario)
        {
            IdUsuario = idUsuario;
        }
    }
}
