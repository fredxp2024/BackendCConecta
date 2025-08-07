using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;
using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Handlers;

public class CrearDatosEmpresaHandler : IRequestHandler<CrearDatosEmpresaCommand, int>
{
    private readonly IDatosEmpresaRepository _repository;

    public CrearDatosEmpresaHandler(IDatosEmpresaRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(CrearDatosEmpresaCommand request, CancellationToken cancellationToken)
    {
        var entidad = new DatosEmpresa
        {
            IdDatosUsuario = request.Datos.IdDatosUsuario,
            RazonSocial = request.Datos.RazonSocial,
            Ruc = request.Datos.Ruc,
            PaginaWeb = request.Datos.PaginaWeb
        };

        await _repository.CrearAsync(entidad);
        return entidad.IdDatosUsuario;
    }
}
