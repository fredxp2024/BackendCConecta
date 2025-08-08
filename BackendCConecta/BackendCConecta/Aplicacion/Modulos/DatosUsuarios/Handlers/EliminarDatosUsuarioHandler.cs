using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

public class EliminarDatosUsuarioHandler : IRequestHandler<EliminarDatosUsuarioCommand, bool>
{
    private readonly IDatosUsuarioRepository _repository;

    public EliminarDatosUsuarioHandler(IDatosUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(EliminarDatosUsuarioCommand request, CancellationToken cancellationToken)
    {
        return await _repository.EliminarAsync(request.IdDatosUsuario, cancellationToken);
    }
}
