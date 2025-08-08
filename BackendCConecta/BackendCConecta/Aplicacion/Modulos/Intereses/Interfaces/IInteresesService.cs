using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces
{
    public interface IInteresesService
    {
        Task<InteresesDto> CrearInteresAsync(CrearInteresesCommand request);
        Task<InteresesDto> ActualizarInteresAsync(ActualizarInteresesCommand request);
        Task<bool> EliminarInteresAsync(int id);
        Task<bool> CambiarEstadoInteresAsync(CambiarEstadoInteresesCommand request);
    }
}
