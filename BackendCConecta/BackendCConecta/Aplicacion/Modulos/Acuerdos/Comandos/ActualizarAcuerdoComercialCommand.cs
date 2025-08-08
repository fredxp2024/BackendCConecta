using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Comandos;

public class ActualizarAcuerdoComercialCommand : ActualizarAcuerdoDto, IRequest<bool>
{
}
