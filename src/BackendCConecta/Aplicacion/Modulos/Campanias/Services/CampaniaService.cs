using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Services;

/// <summary>
/// Service implementation responsible for campaign business logic.
/// </summary>
public class CampaniaService : ICampaniaCommandService, ICampaniaQueryService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public CampaniaService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<int> CrearCampaniaAsync(CampaniaDTO campania)
    {
        var entity = _mapper.Map<Campania>(campania);
        entity.FechaRegistro = DateTime.UtcNow;

        _context.Campanias.Add(entity);
        await _context.SaveChangesAsync();

        return entity.IdCampania;
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<CampaniaDTO>> ObtenerCampaniasAsync()
    {
        var entities = await _context.Campanias.ToListAsync();
        return _mapper.Map<List<CampaniaDTO>>(entities);
    }
}

