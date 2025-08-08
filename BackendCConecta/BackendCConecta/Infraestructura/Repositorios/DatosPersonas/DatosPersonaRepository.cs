using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;
using BackendCConecta.Infraestructura.Persistencia;
using BackendCConecta.Dominio.Entidades.Personas;

namespace BackendCConecta.Infraestructura.Repositorios.DatosPersonas;

public class DatosPersonaRepository : IDatosPersonaRepository
{
    private readonly AppDbContext _context;

    public DatosPersonaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CrearAsync(DatosPersona entidad)
    {
        _context.DatosPersonas.Add(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task ActualizarAsync(DatosPersona entidad)
    {
        _context.DatosPersonas.Update(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarAsync(int idDatosUsuario)
    {
        var entidad = await _context.DatosPersonas.FindAsync(idDatosUsuario);
        if (entidad != null)
        {
            _context.DatosPersonas.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<DatosPersona?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosPersonas
                             .AsNoTracking()
                             .FirstOrDefaultAsync(x => x.IdDatosUsuario == idDatosUsuario);
    }
}
