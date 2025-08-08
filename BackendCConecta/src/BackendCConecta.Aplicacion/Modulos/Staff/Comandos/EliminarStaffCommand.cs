using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Comandos
{
    public class EliminarStaffCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
