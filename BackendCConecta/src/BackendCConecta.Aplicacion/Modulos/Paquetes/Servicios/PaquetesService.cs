using BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos;
using BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs;
using BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Servicios
{
    public class PaquetesService : IPaquetesService
    {
        public Task<PaquetesDto> CrearPaqueteAsync(CrearPaquetesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<PaquetesDto> ActualizarPaqueteAsync(ActualizarPaquetesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarPaqueteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoPaqueteAsync(CambiarEstadoPaquetesCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
