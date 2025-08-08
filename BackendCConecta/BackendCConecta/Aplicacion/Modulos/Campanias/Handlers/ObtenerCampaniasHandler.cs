using BackendCConecta.Aplicacion.Modulos.Campanias.Consultas;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;

/// <summary>
/// Handler that delegates retrieval of campaigns to the service layer.
/// </summary>
public class ObtenerCampaniasHandler : IRequestHandler<ObtenerCampaniasQuery, IReadOnlyList<CampaniaDTO>>
{
    private readonly ICampaniaService _campaniaService;

    public ObtenerCampaniasHandler(ICampaniaService campaniaService)
    {
        _campaniaService = campaniaService;
    }

    /// <inheritdoc />
    public Task<IReadOnlyList<CampaniaDTO>> Handle(ObtenerCampaniasQuery request, CancellationToken cancellationToken)
        => _campaniaService.ObtenerCampaniasAsync();
}

