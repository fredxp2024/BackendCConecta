using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Dominio.Entidades.Ubicaciones;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicaciones;

public class LugaresReferenciaRepository : ILugaresReferenciaRepository
{
    private readonly AppDbContext _context;

    public LugaresReferenciaRepository(AppDbContext context)
        => _context = context;

    public async Task<LugaresReferencia?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _context.LugaresReferencias
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IdLugar == id, cancellationToken);
    }

    public async Task<IEnumerable<LugaresReferencia>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.LugaresReferencias
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task InsertarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default)
    {
        await _context.LugaresReferencias.AddAsync(entidad, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task ActualizarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default)
    {
        _context.LugaresReferencias.Update(entidad);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task EliminarAsync(LugaresReferencia entidad, CancellationToken cancellationToken = default)
    {
        _context.LugaresReferencias.Remove(entidad);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
