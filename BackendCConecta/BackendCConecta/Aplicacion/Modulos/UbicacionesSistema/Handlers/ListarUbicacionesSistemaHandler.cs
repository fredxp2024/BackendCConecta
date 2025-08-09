using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Consultas;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs;
using BackendCConecta.Dominio.Repositorios;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Handlers;

public class ListarUbicacionesSistemaHandler : IRequestHandler<ListarUbicacionesSistemaQuery, List<UbicacionSistemaDto>>
{
    private readonly IUbicacionesSistemaRepository _repository;
    private readonly IMapper _mapper;

    public ListarUbicacionesSistemaHandler(IUbicacionesSistemaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<UbicacionSistemaDto>> Handle(ListarUbicacionesSistemaQuery request, CancellationToken cancellationToken)
    {
        var entidades = await _repository.ListarAsync();
        return _mapper.Map<List<UbicacionSistemaDto>>(entidades);
    }
}

