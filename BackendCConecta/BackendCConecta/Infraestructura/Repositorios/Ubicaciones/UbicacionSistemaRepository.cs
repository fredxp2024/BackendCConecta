using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Ubicaciones;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicaciones;

public class UbicacionSistemaRepository : IUbicacionesSistemaRepository
{
    private readonly AppDbContext _context;

    public UbicacionSistemaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UbicacionSistema?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _context.UbicacionesSistema
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IdUbicacion == id, cancellationToken);
    }

    public async Task<IEnumerable<UbicacionSistema>> ListarAsync(CancellationToken cancellationToken = default)
    {
        return await _context.UbicacionesSistema
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task InsertarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default)
    {
        await _context.UbicacionesSistema.AddAsync(entidad, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task ActualizarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default)
    {
        _context.UbicacionesSistema.Update(entidad);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task EliminarAsync(UbicacionSistema entidad, CancellationToken cancellationToken = default)
    {
        _context.UbicacionesSistema.Remove(entidad);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
