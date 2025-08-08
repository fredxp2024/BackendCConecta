using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using System.Linq;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{

    public class ListarDatosUsuarioHandler : IRequestHandler<ListarDatosUsuarioQuery, List<DatosUsuarioDto>>
    {
        private readonly IDatosUsuarioRepository _repository;

        public ListarDatosUsuarioHandler(IDatosUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DatosUsuarioDto>> Handle(ListarDatosUsuarioQuery request, CancellationToken cancellationToken)
        {
            var entidades = await _repository.ListarAsync(cancellationToken);

            return entidades.Select(d => new DatosUsuarioDto
            {
                IdDatosUsuario = d.IdDatosUsuario,
                IdUsuario = d.IdUsuario,
                Celular = d.Celular,
                Direccion = d.Direccion,
                ImagenPerfil = d.ImagenPerfil,
                TipoUsuario = d.TipoUsuario,
                EstadoColaborador = d.EstadoColaborador,
                EstadoGeneral = d.EstadoGeneral,
                FechaRegistro = d.FechaRegistro
            }).ToList();
        }

    }
}