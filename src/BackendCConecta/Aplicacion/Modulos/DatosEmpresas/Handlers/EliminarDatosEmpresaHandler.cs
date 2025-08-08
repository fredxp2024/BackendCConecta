using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Handlers;

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
