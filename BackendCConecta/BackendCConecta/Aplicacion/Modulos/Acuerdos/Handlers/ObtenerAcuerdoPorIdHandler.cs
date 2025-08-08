using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Consultas;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class ObtenerAcuerdoPorIdHandler : IRequestHandler<ObtenerAcuerdoPorIdQuery, AcuerdoDto?>
{
    private readonly IAcuerdoQueryService _service;
    private readonly IMapper _mapper;

    public ObtenerAcuerdoPorIdHandler(IAcuerdoQueryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<AcuerdoDto?> Handle(ObtenerAcuerdoPorIdQuery request, CancellationToken cancellationToken)
    {
        var acuerdo = await _service.ObtenerPorIdAsync(request.Id);
        return acuerdo is null ? null : _mapper.Map<AcuerdoDto>(acuerdo);
    }
}
