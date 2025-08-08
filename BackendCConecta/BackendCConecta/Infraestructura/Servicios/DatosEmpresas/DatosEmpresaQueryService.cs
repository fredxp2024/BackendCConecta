using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Servicios.DatosEmpresas;

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
            .Select(e => new DatosEmpresaDto
            {
                IdDatosUsuario = e.IdDatosUsuario,
                RazonSocial = e.RazonSocial,
                Ruc = e.Ruc,
                PaginaWeb = e.PaginaWeb
            })
            .ToListAsync();
    }

    public async Task<DatosEmpresaDto?> ObtenerPorIdAsync(int idDatosUsuario)
    {
        return await _context.DatosEmpresas
            .AsNoTracking()
            .Where(e => e.IdDatosUsuario == idDatosUsuario)
            .Select(e => new DatosEmpresaDto
            {
                IdDatosUsuario = e.IdDatosUsuario,
                RazonSocial = e.RazonSocial,
                Ruc = e.Ruc,
                PaginaWeb = e.PaginaWeb
            })
            .FirstOrDefaultAsync();
    }
}
