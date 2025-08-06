using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

public class EliminarDatosUsuarioHandler : IRequestHandler<EliminarDatosUsuarioCommand, bool>
{
    private readonly AppDbContext _context;

    public EliminarDatosUsuarioHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(EliminarDatosUsuarioCommand request, CancellationToken cancellationToken)
    {
        var datos = await _context.DatosUsuarios.FirstOrDefaultAsync(d => d.IdDatosUsuario == request.IdDatosUsuario, cancellationToken);
        if (datos == null) return false;

        _context.DatosUsuarios.Remove(datos);
        await _context.SaveChangesAsync(cancellationToken);

        return true;
    }
}
