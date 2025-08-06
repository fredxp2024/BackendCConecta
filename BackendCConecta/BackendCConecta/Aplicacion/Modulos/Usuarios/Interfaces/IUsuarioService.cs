using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Dominio.Entidades.Usuarios;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;

public interface IUsuarioService
{
    Task ActivarCuentaAsync(int idUsuario);
    Task CambiarContraseñaAsync(int idUsuario, string nuevoPasswordHash);
    Task<Usuario?> ObtenerPorCorreoAsync(string correo);
}


