using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Consultas;

public class ListarDatosEmpresaQuery : IRequest<IEnumerable<DatosEmpresaDto>>
{
}
