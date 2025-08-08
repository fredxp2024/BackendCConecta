using MediatR;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Comandos
{
    public class ActualizarHistorialesCommand : ActualizarHistorialesDto, IRequest<HistorialesDto>
    {
    }
}
