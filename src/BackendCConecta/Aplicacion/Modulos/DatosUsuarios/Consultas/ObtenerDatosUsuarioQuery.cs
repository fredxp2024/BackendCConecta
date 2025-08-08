using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;


namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas
{
    public class ObtenerDatosUsuarioQuery : IRequest<DatosUsuarioDto?>
    {
        public int? IdDatosUsuario { get; set; }
        public int? IdUsuario { get; set; }

        public ObtenerDatosUsuarioQuery(int? idDatosUsuario = null, int? idUsuario = null)
        {
            IdDatosUsuario = idDatosUsuario;
            IdUsuario = idUsuario;
        }
    }
}
