using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Servicios.DatosPersonas;

public class DatosPersonaQueryService : IDatosPersonaQueryService
{
    private readonly AppDbContext _context;

    public DatosPersonaQueryService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DatosPersonaDto>> ListarAsync()
    {
        return await _context.DatosPersonas
            .AsNoTracking()
            .Select(p => new DatosPersonaDto
            {
                IdDatosUsuario = p.IdDatosUsuario,
                Nombres = p.Nombres,
                ApellidoPaterno = p.ApellidoPaterno,
                ApellidoMaterno = p.ApellidoMaterno,
                Dni = p.Dni
            })
            .ToListAsync();
    }

    public async Task<DatosPersonaDto?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosPersonas
            .AsNoTracking()
            .Where(p => p.IdDatosUsuario == idDatosUsuario)
            .Select(p => new DatosPersonaDto
            {
                IdDatosUsuario = p.IdDatosUsuario,
                Nombres = p.Nombres,
                ApellidoPaterno = p.ApellidoPaterno,
                ApellidoMaterno = p.ApellidoMaterno,
                Dni = p.Dni
            })
            .FirstOrDefaultAsync();
    }
}
