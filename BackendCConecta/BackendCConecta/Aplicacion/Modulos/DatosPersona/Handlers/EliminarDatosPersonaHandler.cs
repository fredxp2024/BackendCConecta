using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Handlers;

public class EliminarDatosPersonaHandler : IRequestHandler<EliminarDatosPersonaCommand>
{
    private readonly IDatosPersonaRepository _repository;

    public EliminarDatosPersonaHandler(IDatosPersonaRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(EliminarDatosPersonaCommand request, CancellationToken cancellationToken)
    {
        await _repository.EliminarAsync(request.IdDatosUsuario);
        return Unit.Value;
    }
}
