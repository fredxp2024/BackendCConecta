using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces
{
    public interface IMultimediaService
    {
        Task<MultimediaDto> CrearMultimediaAsync(CrearMultimediaCommand request);
        Task<MultimediaDto> ActualizarMultimediaAsync(ActualizarMultimediaCommand request);
        Task<bool> EliminarMultimediaAsync(int id);
        Task<bool> CambiarEstadoMultimediaAsync(CambiarEstadoMultimediaCommand request);
    }
}
