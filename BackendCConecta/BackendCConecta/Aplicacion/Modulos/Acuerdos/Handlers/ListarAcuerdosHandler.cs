using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Consultas;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class ListarAcuerdosHandler : IRequestHandler<ListarAcuerdosQuery, List<AcuerdoDto>>
{
    private readonly IAcuerdoQueryService _service;
    private readonly IMapper _mapper;

    public ListarAcuerdosHandler(IAcuerdoQueryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<List<AcuerdoDto>> Handle(ListarAcuerdosQuery request, CancellationToken cancellationToken)
    {
        var acuerdos = await _service.ListarAsync();
        return _mapper.Map<List<AcuerdoDto>>(acuerdos);
    }
}
