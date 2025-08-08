using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class ListarUsuariosHandler : IRequestHandler<ListarUsuariosQuery, List<UsuarioDto>>
    {
        private readonly IUsuarioQueryService _usuarioQueryService;

        public ListarUsuariosHandler(IUsuarioQueryService usuarioQueryService)
        {
            _usuarioQueryService = usuarioQueryService;
        }

        public async Task<List<UsuarioDto>> Handle(ListarUsuariosQuery request, CancellationToken cancellationToken)
        {
            return await _usuarioQueryService.ListarAsync(cancellationToken);
        }
    }
}
