using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{

    public class ListarDatosUsuarioHandler : IRequestHandler<ListarDatosUsuarioQuery, List<ActualizarDatosUsuarioDto>>
    {
        private readonly AppDbContext _context;

        public ListarDatosUsuarioHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ActualizarDatosUsuarioDto>> Handle(ListarDatosUsuarioQuery request, CancellationToken cancellationToken)
        {
            return await _context.DatosUsuarios
                .Select(d => new ActualizarDatosUsuarioDto
                {
                    IdDatosUsuario = d.IdDatosUsuario,
                    IdUsuario = d.IdUsuario,
                    Celular = d.Celular,
                    Direccion = d.Direccion,
                    ImagenPerfil = d.ImagenPerfil,
                    EstadoColaborador = d.EstadoColaborador,
                    EstadoGeneral = d.EstadoGeneral
                }).ToListAsync(cancellationToken);
        }

    }
}