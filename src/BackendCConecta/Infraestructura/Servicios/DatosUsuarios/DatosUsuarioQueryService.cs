using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using AutoMapper;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace BackendCConecta.Infraestructura.Servicios.DatosUsuarios;

public class DatosUsuarioQueryService : IDatosUsuarioQueryService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public DatosUsuarioQueryService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<DatosUsuarioDto>> ListarAsync(CancellationToken cancellationToken)
    {
        var datosUsuarios = await _context.DatosUsuarios
            .AsNoTracking()
            .Include(x => x.IdUsuarioNavigation)
            .Include(x => x.DatosPersona)
            .Include(x => x.DatosEmpresa)
            .ToListAsync(cancellationToken);

        return _mapper.Map<List<DatosUsuarioDto>>(datosUsuarios);
    }

    public async Task<DatosUsuarioDto?> ObtenerPorIdAsync(int idDatosUsuario, CancellationToken cancellationToken)
    {
        var datosUsuario = await _context.DatosUsuarios
            .AsNoTracking()
            .Include(x => x.IdUsuarioNavigation)
            .Include(x => x.DatosPersona)
            .Include(x => x.DatosEmpresa)
            .FirstOrDefaultAsync(x => x.IdDatosUsuario == idDatosUsuario, cancellationToken);

        return datosUsuario is null ? null : _mapper.Map<DatosUsuarioDto>(datosUsuario);
    }
}
