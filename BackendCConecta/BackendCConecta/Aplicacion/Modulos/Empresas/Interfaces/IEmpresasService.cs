using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces
{
    public interface IEmpresasService
    {
        Task<EmpresasDto> CrearEmpresasAsync(CrearEmpresasCommand request);
        Task<EmpresasDto> ActualizarEmpresasAsync(ActualizarEmpresasCommand request);
        Task<bool> EliminarEmpresasAsync(int idEmpresa);
        Task<bool> CambiarEstadoEmpresasAsync(int idEmpresa, string estado);
    }
}
