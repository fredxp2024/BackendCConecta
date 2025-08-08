using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Servicios
{
    public class ColaboradoresService : IColaboradoresService
    {
        public Task<ColaboradoresDto> CrearColaboradorAsync(CrearColaboradoresCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<ColaboradoresDto> ActualizarColaboradorAsync(ActualizarColaboradoresCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarColaboradorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoColaboradorAsync(CambiarEstadoColaboradoresCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
