using BackendCConecta.Aplicacion.Modulos.Intereses.Comandos;
using BackendCConecta.Aplicacion.Modulos.Intereses.DTOs;
using BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Intereses.Servicios
{
    public class InteresesService : IInteresesService
    {
        public Task<InteresesDto> CrearInteresAsync(CrearInteresesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<InteresesDto> ActualizarInteresAsync(ActualizarInteresesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarInteresAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoInteresAsync(CambiarEstadoInteresesCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
