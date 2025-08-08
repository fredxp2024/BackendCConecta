using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;
using BackendCConecta.Aplicacion.Modulos.Staff.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Interfaces
{
    public interface IStaffService
    {
        Task<StaffDto> CrearStaffAsync(CrearStaffCommand request);
        Task<StaffDto> ActualizarStaffAsync(ActualizarStaffCommand request);
        Task<bool> EliminarStaffAsync(int id);
    }
}
