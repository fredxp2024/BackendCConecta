using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Handlers;

public class ListarDatosEmpresaHandler : IRequestHandler<ListarDatosEmpresaQuery, IEnumerable<DatosEmpresaDto>>
{
    private readonly IDatosEmpresaQueryService _queryService;

    public ListarDatosEmpresaHandler(IDatosEmpresaQueryService queryService)
    {
        _queryService = queryService;
    }

    public async Task<IEnumerable<DatosEmpresaDto>> Handle(ListarDatosEmpresaQuery request, CancellationToken cancellationToken)
    {
        return await _queryService.ListarAsync();
    }
}
