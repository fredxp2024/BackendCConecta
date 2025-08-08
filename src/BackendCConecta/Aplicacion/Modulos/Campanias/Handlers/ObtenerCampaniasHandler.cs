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
    private readonly ICampaniaQueryService _campaniaQueryService;

    public ObtenerCampaniasHandler(ICampaniaQueryService campaniaQueryService)
    {
        _campaniaQueryService = campaniaQueryService;
    }

    /// <inheritdoc />
    public Task<IReadOnlyList<CampaniaDTO>> Handle(ObtenerCampaniasQuery request, CancellationToken cancellationToken)
        => _campaniaQueryService.ObtenerCampaniasAsync();
}

