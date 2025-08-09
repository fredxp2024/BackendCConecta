using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Handlers;

public class EliminarDatosPersonaHandler : IRequestHandler<EliminarDatosPersonaCommand, Unit>
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
