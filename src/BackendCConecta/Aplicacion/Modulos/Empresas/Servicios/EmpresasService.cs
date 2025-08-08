using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Servicios
{
    public class EmpresasService : IEmpresasService
    {
        public Task<EmpresasDto> CrearEmpresasAsync(CrearEmpresasCommand request)
        {
            // Implementación pendiente
            return Task.FromResult(new EmpresasDto());
        }

        public Task<EmpresasDto> ActualizarEmpresasAsync(ActualizarEmpresasCommand request)
        {
            // Implementación pendiente
            return Task.FromResult(new EmpresasDto());
        }

        public Task<bool> EliminarEmpresasAsync(int idEmpresa)
        {
            // Implementación pendiente
            return Task.FromResult(true);
        }

        public Task<bool> CambiarEstadoEmpresasAsync(int idEmpresa, string estado)
        {
            // Implementación pendiente
            return Task.FromResult(true);
        }
    }
}
