using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;
using BackendCConecta.Aplicacion.Modulos.Staff.DTOs;
using BackendCConecta.Aplicacion.Modulos.Staff.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Servicios
{
    public class StaffService : IStaffService
    {
        public Task<StaffDto> CrearStaffAsync(CrearStaffCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<StaffDto> ActualizarStaffAsync(ActualizarStaffCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarStaffAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
