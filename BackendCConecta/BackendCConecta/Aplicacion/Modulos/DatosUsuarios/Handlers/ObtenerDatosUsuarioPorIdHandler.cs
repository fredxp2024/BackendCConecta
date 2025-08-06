
    using MediatR;
    using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas;
    using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
    using BackendCConecta.Infraestructura.Persistencia;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;
 

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
    public class ObtenerDatosUsuarioPorIdHandler : IRequestHandler<ObtenerDatosUsuarioPorIdQuery, ActualizarDatosUsuarioDto?>
    {
        private readonly AppDbContext _context;

        public ObtenerDatosUsuarioPorIdHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActualizarDatosUsuarioDto?> Handle(ObtenerDatosUsuarioPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.DatosUsuarios
                .Where(d => d.IdDatosUsuario == request.IdDatosUsuario)
                .Select(d => new ActualizarDatosUsuarioDto
                {
                    IdDatosUsuario = d.IdDatosUsuario,
                    IdUsuario = d.IdUsuario,
                    Celular = d.Celular,
                    Direccion = d.Direccion,
                    ImagenPerfil = d.ImagenPerfil,
                    EstadoColaborador = d.EstadoColaborador,
                    EstadoGeneral = d.EstadoGeneral
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}