using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Handlers;

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
