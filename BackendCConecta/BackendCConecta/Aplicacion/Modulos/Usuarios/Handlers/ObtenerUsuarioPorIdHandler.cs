using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class ObtenerUsuarioPorIdHandler : IRequestHandler<ObtenerUsuarioPorIdQuery, UsuarioDto?>
    {
        private readonly IUsuarioQueryService _usuarioQueryService;

        public ObtenerUsuarioPorIdHandler(IUsuarioQueryService usuarioQueryService)
        {
            _usuarioQueryService = usuarioQueryService;
        }

        public async Task<UsuarioDto?> Handle(ObtenerUsuarioPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _usuarioQueryService.ObtenerUsuarioPorIdAsync(request.IdUsuario, cancellationToken);
        }
    }
}
