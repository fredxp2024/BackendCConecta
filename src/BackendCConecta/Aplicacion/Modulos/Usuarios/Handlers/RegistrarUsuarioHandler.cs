using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using System;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Handlers
{
    public class RegistrarUsuarioHandler : IRequestHandler<RegistrarUsuarioCommand, UsuarioDto>
    {
        private readonly IUsuarioCommandService _usuarioCommandService;

        public RegistrarUsuarioHandler(IUsuarioCommandService usuarioCommandService)
        {
            _usuarioCommandService = usuarioCommandService;
        }

        public async Task<UsuarioDto> Handle(RegistrarUsuarioCommand request, CancellationToken cancellationToken)
        {
            return await _usuarioCommandService.RegistrarUsuarioAsync(request);
        }
    }
}
