using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Dominio.Entidades.Acuerdos;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class CrearAcuerdoHandler : IRequestHandler<CrearAcuerdoComercialCommand, int>
{
    private readonly IAcuerdoCommandService _service;
    private readonly IMapper _mapper;

    public CrearAcuerdoHandler(IAcuerdoCommandService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<int> Handle(CrearAcuerdoComercialCommand request, CancellationToken cancellationToken)
    {
        var entidad = _mapper.Map<AcuerdosComercial>(request);
        return await _service.CrearAsync(entidad);
    }
}
