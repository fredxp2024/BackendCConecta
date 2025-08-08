using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class ActualizarUsuarioHandler : IRequestHandler<ActualizarUsuarioCommand, UsuarioDto>
    {
        private readonly IUsuarioCommandService _usuarioCommandService;

        public ActualizarUsuarioHandler(IUsuarioCommandService usuarioCommandService)
        {
            _usuarioCommandService = usuarioCommandService;
        }

        public async Task<UsuarioDto> Handle(ActualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            return await _usuarioCommandService.ActualizarUsuarioAsync(request);
        }
    }
}
