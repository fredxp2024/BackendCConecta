using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Consultas;

public class ListarDatosEmpresaQuery : IRequest<IEnumerable<DatosEmpresaDto>>
{
}
