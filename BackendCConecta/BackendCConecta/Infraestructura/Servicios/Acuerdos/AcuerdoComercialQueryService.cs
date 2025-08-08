using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Dominio.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Infraestructura.Servicios.Acuerdos;

public class AcuerdoComercialQueryService : IAcuerdoQueryService
{
    private readonly IAcuerdoRepository _repository;

    public AcuerdoComercialQueryService(IAcuerdoRepository repository)
    {
        _repository = repository;
    }

    public Task<List<AcuerdosComercial>> ListarAsync() => _repository.ListarAsync();

    public Task<AcuerdosComercial?> ObtenerPorIdAsync(int id) => _repository.ObtenerPorIdAsync(id);

    public Task<List<AcuerdosComercial>> ObtenerPorUsuarioAsync(int idDatosUsuario) =>
        _repository.ObtenerPorUsuarioAsync(idDatosUsuario);
}
