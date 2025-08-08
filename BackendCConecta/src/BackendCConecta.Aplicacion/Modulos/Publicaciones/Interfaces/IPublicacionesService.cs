using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces
{
    public interface IPublicacionesService
    {
        Task<PublicacionesDto> CrearPublicacionAsync(CrearPublicacionesCommand request);
        Task<PublicacionesDto> ActualizarPublicacionAsync(ActualizarPublicacionesCommand request);
        Task<bool> EliminarPublicacionAsync(int id);
        Task<bool> CambiarEstadoPublicacionAsync(CambiarEstadoPublicacionesCommand request);
    }
}
