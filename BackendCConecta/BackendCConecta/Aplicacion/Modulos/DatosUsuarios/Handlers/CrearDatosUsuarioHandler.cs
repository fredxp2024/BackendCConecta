using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Infraestructura.Persistencia;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
 
    public class CrearDatosUsuarioHandler : IRequestHandler<CrearDatosUsuarioCommand, int>
    {
        private readonly AppDbContext _context;

        public CrearDatosUsuarioHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CrearDatosUsuarioCommand request, CancellationToken cancellationToken)
        {
            var datos = new DatosUsuario
            {
                IdUsuario = request.IdUsuario,
                Celular = request.Celular,
                Direccion = request.Direccion,
                ImagenPerfil = request.ImagenPerfil,
                TipoUsuario = request.TipoUsuario,
                EstadoColaborador = request.EstadoColaborador,
                EstadoGeneral = request.EstadoGeneral,
                FechaRegistro = DateTime.UtcNow
            };

            _context.DatosUsuarios.Add(datos);
            await _context.SaveChangesAsync(cancellationToken);

            return datos.IdDatosUsuario;
        }
    }
}