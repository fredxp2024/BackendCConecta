using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;
using BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces
{
    public interface IPaquetesService
    {
        Task<PaquetesDto> CrearPaqueteAsync(CrearPaquetesCommand request);
        Task<PaquetesDto> ActualizarPaqueteAsync(ActualizarPaquetesCommand request);
        Task<bool> EliminarPaqueteAsync(int id);
        Task<bool> CambiarEstadoPaqueteAsync(CambiarEstadoPaquetesCommand request);
    }
}
