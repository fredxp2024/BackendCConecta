using System;
using System.Threading.Tasks;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using BackendCConecta.Infraestructura.Repositorios.Usuarios;

namespace BackendCConecta.Infraestructura.Servicios
{

  

    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task ActivarCuentaAsync(int idUsuario)
        {
            var usuario = await _usuarioRepository.ObtenerPorIdAsync(idUsuario);
            if (usuario == null)
                throw new Exception("Usuario no encontrado.");

            usuario.Estado = EstadoUsuario.Activo;
            await _usuarioRepository.ActualizarAsync(usuario);
        }
        public async Task<Usuario?> ObtenerPorCorreoAsync(string correo)
        {
            return await _usuarioRepository.ObtenerPorCorreoAsync(correo);
        }
        public async Task CambiarContraseñaAsync(int idUsuario, string nuevoPasswordHash)
        {
            var usuario = await _usuarioRepository.ObtenerPorIdAsync(idUsuario);
            if (usuario == null)
                throw new Exception("Usuario no encontrado.");

            usuario.PasswordHash = nuevoPasswordHash;
            await _usuarioRepository.ActualizarAsync(usuario);
        }
    }
}