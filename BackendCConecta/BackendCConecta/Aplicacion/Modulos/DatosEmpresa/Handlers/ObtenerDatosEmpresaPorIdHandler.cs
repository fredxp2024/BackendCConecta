using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Handlers;

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
