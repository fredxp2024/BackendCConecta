using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Handlers;

public class ListarDatosPersonaHandler : IRequestHandler<ListarDatosPersonaQuery, IEnumerable<DatosPersonaDto>>
{
    private readonly IDatosPersonaQueryService _queryService;

    public ListarDatosPersonaHandler(IDatosPersonaQueryService queryService)
    {
        _queryService = queryService;
    }

    public async Task<IEnumerable<DatosPersonaDto>> Handle(ListarDatosPersonaQuery request, CancellationToken cancellationToken)
    {
        return await _queryService.ListarAsync();
    }
}
