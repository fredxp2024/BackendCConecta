using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.DatosPersona;

public class DatosPersonaRepository : IDatosPersonaRepository
{
    private readonly AppDbContext _context;

    public DatosPersonaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CrearAsync(DatosPersona entidad)
    {
        _context.DatosPersona.Add(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task ActualizarAsync(DatosPersona entidad)
    {
        _context.DatosPersona.Update(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarAsync(int idDatosUsuario)
    {
        var entidad = await _context.DatosPersona.FindAsync(idDatosUsuario);
        if (entidad != null)
        {
            _context.DatosPersona.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<DatosPersona?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosPersona
                             .AsNoTracking()
                             .FirstOrDefaultAsync(x => x.IdDatosUsuario == idDatosUsuario);
    }
}
