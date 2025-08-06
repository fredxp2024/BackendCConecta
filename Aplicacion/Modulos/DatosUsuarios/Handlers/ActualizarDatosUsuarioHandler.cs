using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
    public class ActualizarDatosUsuarioHandler : IRequestHandler<ActualizarDatosUsuarioCommand, bool>
{
    private readonly AppDbContext _context;

    public ActualizarDatosUsuarioHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(ActualizarDatosUsuarioCommand request, CancellationToken cancellationToken)
    {
        var datos = await _context.DatosUsuarios.FirstOrDefaultAsync(d => d.IdDatosUsuario == request.IdDatosUsuario, cancellationToken);
        if (datos == null) return false;

        datos.Celular = request.Celular;
        datos.Direccion = request.Direccion;
        datos.ImagenPerfil = request.ImagenPerfil;
        datos.EstadoColaborador = request.EstadoColaborador;
        datos.EstadoGeneral = request.EstadoGeneral;

        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
}