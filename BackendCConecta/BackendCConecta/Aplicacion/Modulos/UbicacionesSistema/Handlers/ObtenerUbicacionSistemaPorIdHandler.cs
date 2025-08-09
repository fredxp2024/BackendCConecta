using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Consultas;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs;
using BackendCConecta.Dominio.Repositorios;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Handlers;

public class ObtenerUbicacionSistemaPorIdHandler : IRequestHandler<ObtenerUbicacionSistemaPorIdQuery, UbicacionSistemaDto?>
{
    private readonly IUbicacionesSistemaRepository _repository;
    private readonly IMapper _mapper;

    public ObtenerUbicacionSistemaPorIdHandler(IUbicacionesSistemaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<UbicacionSistemaDto?> Handle(ObtenerUbicacionSistemaPorIdQuery request, CancellationToken cancellationToken)
    {
        var entidad = await _repository.ObtenerPorIdAsync(request.Id);
        return entidad is null ? null : _mapper.Map<UbicacionSistemaDto>(entidad);
    }
}

