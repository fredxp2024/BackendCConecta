using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Servicios.DatosEmpresa;

public class DatosEmpresaQueryService : IDatosEmpresaQueryService
{
    private readonly AppDbContext _context;

    public DatosEmpresaQueryService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DatosEmpresaDto>> ListarAsync()
    {
        return await _context.DatosEmpresas
            .AsNoTracking()
            .Include(e => e.IdDatosUsuarioNavigation)
                .ThenInclude(u => u.DatosPersona)
            .Select(e => new DatosEmpresaDto
            {
                IdDatosUsuario = e.IdDatosUsuario,
                RazonSocial = e.RazonSocial,
                Ruc = e.Ruc ?? string.Empty,
                PaginaWeb = e.PaginaWeb,
                Nombres = e.IdDatosUsuarioNavigation.DatosPersona != null ? e.IdDatosUsuarioNavigation.DatosPersona.Nombres : null,
                ApellidoPaterno = e.IdDatosUsuarioNavigation.DatosPersona?.ApellidoPaterno,
                ApellidoMaterno = e.IdDatosUsuarioNavigation.DatosPersona?.ApellidoMaterno,
                Dni = e.IdDatosUsuarioNavigation.DatosPersona?.Dni
            })
            .ToListAsync();
    }

    public async Task<DatosEmpresaDto?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosEmpresas
            .AsNoTracking()
            .Where(e => e.IdDatosUsuario == idDatosUsuario)
            .Include(e => e.IdDatosUsuarioNavigation)
                .ThenInclude(u => u.DatosPersona)
            .Select(e => new DatosEmpresaDto
            {
                IdDatosUsuario = e.IdDatosUsuario,
                RazonSocial = e.RazonSocial,
                Ruc = e.Ruc ?? string.Empty,
                PaginaWeb = e.PaginaWeb,
                Nombres = e.IdDatosUsuarioNavigation.DatosPersona != null ? e.IdDatosUsuarioNavigation.DatosPersona.Nombres : null,
                ApellidoPaterno = e.IdDatosUsuarioNavigation.DatosPersona?.ApellidoPaterno,
                ApellidoMaterno = e.IdDatosUsuarioNavigation.DatosPersona?.ApellidoMaterno,
                Dni = e.IdDatosUsuarioNavigation.DatosPersona?.Dni
            })
            .FirstOrDefaultAsync();
    }
}
