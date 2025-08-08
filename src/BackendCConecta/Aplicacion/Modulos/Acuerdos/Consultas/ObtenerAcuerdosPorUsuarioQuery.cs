using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;
using System.Collections.Generic;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Consultas;

public class ObtenerAcuerdosPorUsuarioQuery : IRequest<List<AcuerdoDto>>
{
    public int IdDatosUsuario { get; set; }
}
