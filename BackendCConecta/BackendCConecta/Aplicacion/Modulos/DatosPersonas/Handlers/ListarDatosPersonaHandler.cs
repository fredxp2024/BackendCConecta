using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Handlers;

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
