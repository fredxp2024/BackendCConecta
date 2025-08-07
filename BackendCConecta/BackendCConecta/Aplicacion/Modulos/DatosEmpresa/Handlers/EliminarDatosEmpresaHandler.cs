using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Handlers;

public class EliminarDatosEmpresaHandler : IRequestHandler<EliminarDatosEmpresaCommand>
{
    private readonly IDatosEmpresaRepository _repository;

    public EliminarDatosEmpresaHandler(IDatosEmpresaRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(EliminarDatosEmpresaCommand request, CancellationToken cancellationToken)
    {
        await _repository.EliminarAsync(request.IdDatosUsuario);
        return Unit.Value;
    }
}
