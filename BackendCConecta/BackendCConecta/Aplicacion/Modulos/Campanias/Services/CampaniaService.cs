using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Services;

/// <summary>
/// Service implementation responsible for campaign business logic.
/// </summary>
public class CampaniaService : ICampaniaService
{
    private readonly AppDbContext _context;

    public CampaniaService(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<int> CrearCampaniaAsync(CampaniaDTO campania)
    {
        var entity = new Campania
        {
            Titulo = campania.Titulo,
            Descripcion = campania.Descripcion,
            TipoCampania = campania.TipoCampania,
            FechaInicio = campania.FechaInicio,
            FechaFin = campania.FechaFin,
            Estado = campania.Estado,
            IdUbicacion = campania.IdUbicacion,
            IdStaff = campania.IdStaff,
            FechaRegistro = DateTime.UtcNow
        };

        _context.Campanias.Add(entity);
        await _context.SaveChangesAsync();

        return entity.IdCampania;
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<CampaniaDTO>> ObtenerCampaniasAsync()
    {
        return await _context.Campanias
            .Select(c => new CampaniaDTO
            {
                IdCampania = c.IdCampania,
                Titulo = c.Titulo,
                Descripcion = c.Descripcion,
                TipoCampania = c.TipoCampania,
                FechaInicio = c.FechaInicio,
                FechaFin = c.FechaFin,
                Estado = c.Estado,
                IdUbicacion = c.IdUbicacion,
                IdStaff = c.IdStaff
            })
            .ToListAsync();
    }
}

