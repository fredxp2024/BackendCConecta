using AutoMapper;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Comandos;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Dominio.Entidades.Acuerdos;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Handlers;

public class ActualizarAcuerdoHandler : IRequestHandler<ActualizarAcuerdoComercialCommand, bool>
{
    private readonly IAcuerdoCommandService _service;
    private readonly IMapper _mapper;

    public ActualizarAcuerdoHandler(IAcuerdoCommandService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<bool> Handle(ActualizarAcuerdoComercialCommand request, CancellationToken cancellationToken)
    {
        var entidad = _mapper.Map<AcuerdosComercial>(request);
        return await _service.ActualizarAsync(entidad);
    }
}
