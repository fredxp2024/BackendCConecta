using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;

/// <summary>
/// Handler responsible for creating campaigns.
/// </summary>
public class CrearCampaniaHandler : IRequestHandler<CrearCampaniaCommand, int>
{
    private readonly ICampaniaCommandService _campaniaCommandService;
    private readonly IMapper _mapper;

    public CrearCampaniaHandler(ICampaniaCommandService campaniaCommandService, IMapper mapper)
    {
        _campaniaCommandService = campaniaCommandService;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public Task<int> Handle(CrearCampaniaCommand request, CancellationToken cancellationToken)
    {
        var dto = _mapper.Map<CampaniaDTO>(request);
        return _campaniaCommandService.CrearCampaniaAsync(dto);
    }
}

