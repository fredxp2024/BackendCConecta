using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces
{
    public interface IColaboradoresService
    {
        Task<ColaboradoresDto> CrearColaboradorAsync(CrearColaboradoresCommand request);
        Task<ColaboradoresDto> ActualizarColaboradorAsync(ActualizarColaboradoresCommand request);
        Task<bool> EliminarColaboradorAsync(int id);
        Task<bool> CambiarEstadoColaboradorAsync(CambiarEstadoColaboradoresCommand request);
    }
}
