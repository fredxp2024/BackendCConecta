using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicationes;

public class LugaresReferenciaRepository : ILugaresReferenciaRepository
{
    private readonly AppDbContext _context;

    public LugaresReferenciaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<LugaresReferencia?> ObtenerPorIdAsync(int id)
    {
        return await _context.LugaresReferencias.FindAsync(id);
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
