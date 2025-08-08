using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;
using BackendCConecta.Aplicacion.Modulos.Multimedia.DTOs;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Servicios
{
    public class MultimediaService : IMultimediaService
    {
        public Task<MultimediaDto> CrearMultimediaAsync(CrearMultimediaCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<MultimediaDto> ActualizarMultimediaAsync(ActualizarMultimediaCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarMultimediaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoMultimediaAsync(CambiarEstadoMultimediaCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
