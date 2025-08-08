using BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;
using BackendCConecta.Dominio.Entidades.Acuerdos;
using BackendCConecta.Infraestructura.Repositorios.Acuerdos;
using System.Threading.Tasks;

namespace BackendCConecta.Infraestructura.Servicios.Acuerdos;

public class AcuerdoComercialCommandService : IAcuerdoCommandService
{
    private readonly AcuerdoRepository _repository;

    public AcuerdoComercialCommandService(AcuerdoRepository repository)
    {
        _repository = repository;
    }

    public Task<int> CrearAsync(AcuerdosComercial entidad) => _repository.CrearAsync(entidad);

    public Task<bool> ActualizarAsync(AcuerdosComercial entidad) => _repository.ActualizarAsync(entidad);

    public Task<bool> EliminarAsync(int id) => _repository.EliminarAsync(id);
}
