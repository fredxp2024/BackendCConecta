using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCConecta.Infraestructura.Repositorios.Acuerdos;

public class AcuerdoRepository : IAcuerdoRepository
{
    private readonly AppDbContext _context;

    public AcuerdoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<AcuerdosComercial?> ObtenerPorIdAsync(int id)
    {
        return await _context.AcuerdosComerciales.FindAsync(id);
    }

    public async Task<List<AcuerdosComercial>> ListarAsync()
    {
        return await _context.AcuerdosComerciales
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<AcuerdosComercial>> ObtenerPorUsuarioAsync(int idDatosUsuario)
    {
        return await _context.AcuerdosComerciales
            .AsNoTracking()
            .Where(a => a.IdDatosUsuario == idDatosUsuario)
            .ToListAsync();
    }

    public async Task<int> CrearAsync(AcuerdosComercial entidad)
    {
        await _context.AcuerdosComerciales.AddAsync(entidad);
        await _context.SaveChangesAsync();
        return entidad.IdAcuerdo;
    }

    public async Task<bool> ActualizarAsync(AcuerdosComercial entidad)
    {
        _context.AcuerdosComerciales.Update(entidad);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> EliminarAsync(int id)
    {
        var entidad = await _context.AcuerdosComerciales.FindAsync(id);
        if (entidad == null)
        {
            return false;
        }

        _context.AcuerdosComerciales.Remove(entidad);
        return await _context.SaveChangesAsync() > 0;
    }
}
