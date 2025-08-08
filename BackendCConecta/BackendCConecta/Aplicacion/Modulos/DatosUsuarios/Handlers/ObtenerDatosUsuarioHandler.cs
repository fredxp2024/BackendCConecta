
using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
    public class ObtenerDatosUsuarioHandler : IRequestHandler<ObtenerDatosUsuarioQuery, DatosUsuarioDto?>
    {
        private readonly IDatosUsuarioRepository _repository;

        public ObtenerDatosUsuarioHandler(IDatosUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<DatosUsuarioDto?> Handle(ObtenerDatosUsuarioQuery request, CancellationToken cancellationToken)
        {
            var entidad = await _repository.ObtenerAsync(request.IdDatosUsuario, request.IdUsuario, cancellationToken);
            if (entidad is null) return null;

            return new DatosUsuarioDto
            {
                IdDatosUsuario = entidad.IdDatosUsuario,
                IdUsuario = entidad.IdUsuario,
                Celular = entidad.Celular,
                Direccion = entidad.Direccion,
                ImagenPerfil = entidad.ImagenPerfil,
                TipoUsuario = entidad.TipoUsuario,
                EstadoColaborador = entidad.EstadoColaborador,
                EstadoGeneral = entidad.EstadoGeneral,
                FechaRegistro = entidad.FechaRegistro
            };
        }
    }
}