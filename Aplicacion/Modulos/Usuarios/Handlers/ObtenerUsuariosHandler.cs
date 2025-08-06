using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class ObtenerUsuariosHandler : IRequestHandler<ObtenerUsuariosQuery, UsuarioDto>
    {
        private readonly IUsuarioQueryService _usuarioQueryService;

        public ObtenerUsuariosHandler(IUsuarioQueryService usuarioQueryService)
        {
            _usuarioQueryService = usuarioQueryService;
        }

        public async Task<UsuarioDto> Handle(ObtenerUsuariosQuery request, CancellationToken cancellationToken)
        {
            return await _usuarioQueryService.ObtenerUsuarioPorIdAsync(request.IdUsuario);
        }
    }
}
