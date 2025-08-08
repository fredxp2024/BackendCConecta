using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Comandos;

public class EliminarAcuerdoComercialCommand : IRequest<bool>
{
    public int Id { get; set; }
}
