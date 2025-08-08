using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;
using BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces;
using System;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Servicios
{
    public class HistorialesService : IHistorialesService
    {
        public Task<HistorialesDto> CrearHistorialAsync(CrearHistorialesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<HistorialesDto> ActualizarHistorialAsync(ActualizarHistorialesCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarHistorialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CambiarEstadoHistorialAsync(CambiarEstadoHistorialesCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
