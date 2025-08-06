using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Handlers;

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
