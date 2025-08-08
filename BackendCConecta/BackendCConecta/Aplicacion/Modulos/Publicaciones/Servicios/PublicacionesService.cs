using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.DTOs;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Servicios
{
    public class PublicacionesService : IPublicacionesService
    {
        public Task<PublicacionesDto> CrearPublicacionAsync(CrearPublicacionesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<PublicacionesDto> ActualizarPublicacionAsync(ActualizarPublicacionesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarPublicacionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoPublicacionAsync(CambiarEstadoPublicacionesCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
