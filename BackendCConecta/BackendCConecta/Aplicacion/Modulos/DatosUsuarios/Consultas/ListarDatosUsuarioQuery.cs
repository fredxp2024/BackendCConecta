using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using System.Collections.Generic;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas
{
    public class ListarDatosUsuarioQuery : IRequest<List<DatosUsuarioDto>>
    {
    }
}
