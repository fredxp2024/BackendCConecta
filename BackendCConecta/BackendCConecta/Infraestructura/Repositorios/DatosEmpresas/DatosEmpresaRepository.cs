using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Dominio.Entidades.Empresas;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.DatosEmpresas;

public class DatosEmpresaRepository : IDatosEmpresaRepository
{
    private readonly AppDbContext _context;

    public DatosEmpresaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CrearAsync(DatosEmpresa entidad)
    {
        _context.DatosEmpresas.Add(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task ActualizarAsync(DatosEmpresa entidad)
    {
        _context.DatosEmpresas.Update(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarAsync(int idDatosUsuario)
    {
        var entidad = await _context.DatosEmpresas.FindAsync(idDatosUsuario);
        if (entidad != null)
        {
            _context.DatosEmpresas.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<DatosEmpresa?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosEmpresas
                             .AsNoTracking()
                             .FirstOrDefaultAsync(x => x.IdDatosUsuario == idDatosUsuario);
    }
}
