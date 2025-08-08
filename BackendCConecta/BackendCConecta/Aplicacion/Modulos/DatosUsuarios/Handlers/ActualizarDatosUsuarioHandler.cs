using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Handlers
{
    public class ActualizarDatosUsuarioHandler : IRequestHandler<ActualizarDatosUsuarioCommand, bool>
{
    private readonly IDatosUsuarioRepository _repository;

    public ActualizarDatosUsuarioHandler(IDatosUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(ActualizarDatosUsuarioCommand request, CancellationToken cancellationToken)
    {
        var datos = await _repository.ObtenerAsync(request.IdDatosUsuario, null, cancellationToken);
        if (datos == null) return false;

        datos.Celular = request.Celular;
        datos.Direccion = request.Direccion;
        datos.ImagenPerfil = request.ImagenPerfil;
        datos.EstadoColaborador = request.EstadoColaborador;
        datos.EstadoGeneral = request.EstadoGeneral;

        return await _repository.ActualizarAsync(datos, cancellationToken);
    }
}
}