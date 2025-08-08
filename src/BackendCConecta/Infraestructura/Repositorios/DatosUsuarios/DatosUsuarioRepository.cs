using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackendCConecta.Infraestructura.Repositorios.DatosUsuarios;

public class DatosUsuarioRepository : IDatosUsuarioRepository
{
    private readonly AppDbContext _context;

    public DatosUsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<DatosUsuario> CrearAsync(DatosUsuario entidad, CancellationToken cancellationToken)
    {
        await _context.DatosUsuarios.AddAsync(entidad, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return entidad;
    }

    public async Task<bool> ActualizarAsync(DatosUsuario entidad, CancellationToken cancellationToken)
    {
        _context.DatosUsuarios.Update(entidad);
        return await _context.SaveChangesAsync(cancellationToken) > 0;
    }

    public async Task<bool> EliminarAsync(int idDatosUsuario, CancellationToken cancellationToken)
    {
        var entidad = await _context.DatosUsuarios.FindAsync(new object?[] { idDatosUsuario }, cancellationToken);
        if (entidad is null)
        {
            return false;
        }

        _context.DatosUsuarios.Remove(entidad);
        return await _context.SaveChangesAsync(cancellationToken) > 0;
    }

    public async Task<List<DatosUsuario>> ListarAsync(CancellationToken cancellationToken)
    {
        return await _context.DatosUsuarios.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<DatosUsuario?> ObtenerAsync(int? idDatosUsuario, int? idUsuario, CancellationToken cancellationToken)
    {
        return await _context.DatosUsuarios.AsNoTracking()
            .FirstOrDefaultAsync(d =>
                (!idDatosUsuario.HasValue || d.IdDatosUsuario == idDatosUsuario) &&
                (!idUsuario.HasValue || d.IdUsuario == idUsuario), cancellationToken);
    }
}
