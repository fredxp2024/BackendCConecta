using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Comandos
{
    /// <summary>
    /// Comando para asignar un rol a un usuario.
    /// </summary>
    public class AsignarRolCommand : IRequest<bool>
    {
        /// <summary>
        /// Identificador del usuario al que se le asignará el rol.
        /// </summary>
        public int IdDatosUsuario { get; set; }

        /// <summary>
        /// Identificador del rol a asignar.
        /// </summary>
        public int IdRol { get; set; }
    }
}

