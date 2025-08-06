using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class EliminarUsuarioHandler : IRequestHandler<EliminarUsuarioCommand, bool>
    {
        private readonly IUsuarioCommandService _usuarioCommandService;

        public EliminarUsuarioHandler(IUsuarioCommandService usuarioCommandService)
        {
            _usuarioCommandService = usuarioCommandService;
        }

        public async Task<bool> Handle(EliminarUsuarioCommand request, CancellationToken cancellationToken)
        {
            return await _usuarioCommandService.EliminarUsuarioAsync(request.IdUsuario);
        }
    }
}
