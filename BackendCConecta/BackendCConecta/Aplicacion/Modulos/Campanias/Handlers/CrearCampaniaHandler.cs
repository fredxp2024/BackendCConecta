using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;

/// <summary>
/// Handler responsible for creating campaigns.
/// </summary>
public class CrearCampaniaHandler : IRequestHandler<CrearCampaniaCommand, int>
{
    private readonly ICampaniaService _campaniaService;

    public CrearCampaniaHandler(ICampaniaService campaniaService)
    {
        _campaniaService = campaniaService;
    }

    /// <inheritdoc />
    public Task<int> Handle(CrearCampaniaCommand request, CancellationToken cancellationToken)
    {
        var dto = new CampaniaDTO
        {
            Titulo = request.Titulo,
            Descripcion = request.Descripcion,
            TipoCampania = request.TipoCampania,
            FechaInicio = request.FechaInicio,
            FechaFin = request.FechaFin,
            Estado = request.Estado,
            IdUbicacion = request.IdUbicacion,
            IdStaff = request.IdStaff
        };

        return _campaniaService.CrearCampaniaAsync(dto);
    }
}

