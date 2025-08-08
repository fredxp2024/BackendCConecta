using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Interfaces
{
    /// <summary>
    /// Define las operaciones para gestionar asignaciones de roles.
    /// </summary>
    public interface IRolCommandService
    {
        /// <summary>
        /// Asigna un rol a un usuario.
        /// </summary>
        Task<bool> AsignarRolAsync(int idDatosUsuario, int idRol);

        /// <summary>
        /// Remueve un rol de un usuario.
        /// </summary>
        Task<bool> RemoverRolAsync(int idDatosUsuario, int idRol);
    }
}

