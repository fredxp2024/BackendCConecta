using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Consultas;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class ObtenerAcuerdosPorUsuarioHandler : IRequestHandler<ObtenerAcuerdosPorUsuarioQuery, List<AcuerdoDto>>
{
    private readonly IAcuerdoQueryService _service;
    private readonly IMapper _mapper;

    public ObtenerAcuerdosPorUsuarioHandler(IAcuerdoQueryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<List<AcuerdoDto>> Handle(ObtenerAcuerdosPorUsuarioQuery request, CancellationToken cancellationToken)
    {
        var acuerdos = await _service.ObtenerPorUsuarioAsync(request.IdDatosUsuario);
        return _mapper.Map<List<AcuerdoDto>>(acuerdos);
    }
}
