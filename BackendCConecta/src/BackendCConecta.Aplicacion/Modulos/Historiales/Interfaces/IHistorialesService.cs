using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces
{
    public interface IHistorialesService
    {
        Task<HistorialesDto> CrearHistorialAsync(CrearHistorialesCommand request);
        Task<HistorialesDto> ActualizarHistorialAsync(ActualizarHistorialesCommand request);
        Task<bool> EliminarHistorialAsync(int id);
        Task<bool> CambiarEstadoHistorialAsync(CambiarEstadoHistorialesCommand request);
    }
}
