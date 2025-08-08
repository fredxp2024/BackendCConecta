using MediatR;
using BackendCConecta.Aplicacion.Modulos.Acuerdos.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Consultas;

public class ObtenerAcuerdoPorIdQuery : IRequest<AcuerdoDto?>
{
    public int Id { get; set; }
}
