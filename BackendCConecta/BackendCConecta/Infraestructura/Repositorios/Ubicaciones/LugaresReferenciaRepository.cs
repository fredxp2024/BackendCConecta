using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicaciones;

public class LugaresReferenciaRepository : ILugaresReferenciaRepository
{
    private readonly AppDbContext _context;

    public LugaresReferenciaRepository(AppDbContext context)
        => _context = context;

    public async Task<LugaresReferencia?> ObtenerPorIdAsync(int id)
    {
        return await _context.LugaresReferencias
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IdLugar == id);
    }

    public async Task<IEnumerable<LugaresReferencia>> ListarAsync()
    {
        return await _context.LugaresReferencias
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task InsertarAsync(LugaresReferencia entidad)
    {
        await _context.LugaresReferencias.AddAsync(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task ActualizarAsync(LugaresReferencia entidad)
    {
        _context.LugaresReferencias.Update(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarAsync(LugaresReferencia entidad)
    {
        _context.LugaresReferencias.Remove(entidad);
        await _context.SaveChangesAsync();
    }
}
