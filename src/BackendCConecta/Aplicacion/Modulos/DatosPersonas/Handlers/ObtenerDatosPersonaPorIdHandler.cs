using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Handlers;

public class ObtenerDatosPersonaPorIdHandler : IRequestHandler<ObtenerDatosPersonaPorIdQuery, DatosPersonaDto?>
{
    private readonly IDatosPersonaQueryService _queryService;

    public ObtenerDatosPersonaPorIdHandler(IDatosPersonaQueryService queryService)
    {
        _queryService = queryService;
    }

    public async Task<DatosPersonaDto?> Handle(ObtenerDatosPersonaPorIdQuery request, CancellationToken cancellationToken)
    {
        return await _queryService.ObtenerPorIdAsync(request.IdDatosUsuario);
    }
}
