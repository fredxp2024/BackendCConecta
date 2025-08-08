using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Handlers;

public class ObtenerDatosEmpresaPorIdHandler : IRequestHandler<ObtenerDatosEmpresaPorIdQuery, DatosEmpresaDto?>
{
    private readonly IDatosEmpresaQueryService _queryService;

    public ObtenerDatosEmpresaPorIdHandler(IDatosEmpresaQueryService queryService)
    {
        _queryService = queryService;
    }

    public async Task<DatosEmpresaDto?> Handle(ObtenerDatosEmpresaPorIdQuery request, CancellationToken cancellationToken)
    {
        return await _queryService.ObtenerPorIdAsync(request.IdDatosUsuario);
    }
}
