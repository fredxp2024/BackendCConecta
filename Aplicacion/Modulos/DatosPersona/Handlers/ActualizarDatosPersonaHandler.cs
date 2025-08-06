using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Handlers;

public class ActualizarDatosPersonaHandler : IRequestHandler<ActualizarDatosPersonaCommand>
{
    private readonly IDatosPersonaRepository _repository;

    public ActualizarDatosPersonaHandler(IDatosPersonaRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(ActualizarDatosPersonaCommand request, CancellationToken cancellationToken)
    {
        var persona = await _repository.ObtenerPorIdAsync(request.IdDatosUsuario)
                      ?? throw new KeyNotFoundException("DatosPersona no encontrada.");

        persona.Nombres = request.Datos.Nombres;
        persona.ApellidoPaterno = request.Datos.ApellidoPaterno;
        persona.ApellidoMaterno = request.Datos.ApellidoMaterno;
        persona.Dni = request.Datos.Dni;

        await _repository.ActualizarAsync(persona);
        return Unit.Value;
    }
}
