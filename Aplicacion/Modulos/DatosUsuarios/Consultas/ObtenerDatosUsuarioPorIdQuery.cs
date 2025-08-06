using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;


namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas
{
    public class ObtenerDatosUsuarioPorIdQuery : IRequest<DatosUsuarioDto?>
    {
        public int IdDatosUsuario { get; set; }

        public ObtenerDatosUsuarioPorIdQuery(int idDatosUsuario)
        {
            IdDatosUsuario = idDatosUsuario;
        }
    }
}
