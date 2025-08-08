using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Consultas;

public class ListarDatosPersonaQuery : IRequest<IEnumerable<DatosPersonaDto>>
{
}
