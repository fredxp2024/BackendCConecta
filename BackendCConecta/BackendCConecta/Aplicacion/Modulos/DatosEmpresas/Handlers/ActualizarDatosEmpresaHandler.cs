using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Handlers;

public class ActualizarDatosEmpresaHandler : IRequestHandler<ActualizarDatosEmpresaCommand, Unit>
{
    private readonly IDatosEmpresaRepository _repository;

    public ActualizarDatosEmpresaHandler(IDatosEmpresaRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(ActualizarDatosEmpresaCommand request, CancellationToken cancellationToken)
    {
        var empresa = await _repository.ObtenerPorIdAsync(request.IdDatosUsuario)
            ?? throw new KeyNotFoundException("DatosEmpresa no encontrada.");

        empresa.RazonSocial = request.Datos.RazonSocial;
        empresa.Ruc = request.Datos.Ruc;
        empresa.PaginaWeb = request.Datos.PaginaWeb;

        await _repository.ActualizarAsync(empresa);
        return Unit.Value;
    }
}
