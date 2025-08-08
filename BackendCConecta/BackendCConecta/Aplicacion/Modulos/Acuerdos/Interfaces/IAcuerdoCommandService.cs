using BackendCConecta.Dominio.Entidades.Acuerdos;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

public interface IAcuerdoCommandService
{
    Task<int> CrearAsync(AcuerdosComercial entidad);
    Task<bool> ActualizarAsync(AcuerdosComercial entidad);
    Task<bool> EliminarAsync(int id);
}
