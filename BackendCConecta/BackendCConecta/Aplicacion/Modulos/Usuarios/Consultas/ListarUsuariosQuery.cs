using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using System.Collections.Generic;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas
{
    public class ListarUsuariosQuery : IRequest<List<UsuarioDto>>
    {
    }
}

