using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;
using BackendCConecta.Dominio.Entidades.Personas;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Handlers;

public class CrearDatosPersonaHandler : IRequestHandler<CrearDatosPersonaCommand, int>
{
    private readonly IDatosPersonaRepository _repository;

    public CrearDatosPersonaHandler(IDatosPersonaRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(CrearDatosPersonaCommand request, CancellationToken cancellationToken)
    {
        var entidad = new DatosPersona
        {
            IdDatosUsuario = request.Datos.IdDatosUsuario,
            Nombres = request.Datos.Nombres,
            ApellidoPaterno = request.Datos.ApellidoPaterno,
            ApellidoMaterno = request.Datos.ApellidoMaterno,
            Dni = request.Datos.Dni
        };

        await _repository.CrearAsync(entidad);
        return entidad.IdDatosUsuario;
    }
}
