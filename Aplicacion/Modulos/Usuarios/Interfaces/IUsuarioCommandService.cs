using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;

using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces
{
    public interface IUsuarioCommandService
    {
        Task<UsuarioDto> RegistrarUsuarioAsync(RegistrarUsuarioCommand request);
        Task<UsuarioDto> ActualizarUsuarioAsync(ActualizarUsuarioCommand request);
        Task<bool> EliminarUsuarioAsync(int idUsuario);
    }
}
