using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Handlers;

public class ActualizarDatosEmpresaHandler : IRequestHandler<ActualizarDatosEmpresaCommand>
{
    private readonly IDatosEmpresaRepository _repository;

    public ActualizarDatosEmpresaHandler(IDatosEmpresaRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(ActualizarDatosEmpresaCommand request, CancellationToken cancellationToken)
    {
        var empresa = await _repository.ObtenerPorIdAsync(request.IdDatosUsuario);
        ValidarExistencia(empresa);

        empresa.RazonSocial = request.Datos.RazonSocial;
        empresa.Ruc = request.Datos.Ruc;
        empresa.PaginaWeb = request.Datos.PaginaWeb;

        await _repository.ActualizarAsync(empresa);
        return Unit.Value;
    }

    private static void ValidarExistencia(DatosEmpresa? empresa)
    {
        if (empresa == null)
            throw new KeyNotFoundException("DatosEmpresa no encontrada.");
    }
}
