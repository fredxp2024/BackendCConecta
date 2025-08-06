using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Consultas;

public class ListarDatosPersonaQuery : IRequest<IEnumerable<DatosPersonaDto>>
{
}
