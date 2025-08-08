using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Roles.Comandos
{
    /// <summary>
    /// Comando para remover un rol previamente asignado a un usuario.
    /// </summary>
    public class RemoverRolCommand : IRequest<bool>
    {
        /// <summary>
        /// Identificador del usuario al que se le removerá el rol.
        /// </summary>
        public int IdDatosUsuario { get; set; }

        /// <summary>
        /// Identificador del rol a remover.
        /// </summary>
        public int IdRol { get; set; }
    }
}

