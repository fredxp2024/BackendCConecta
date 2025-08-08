using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;
using BackendCConecta.Aplicacion.Modulos.Staff.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Handlers
{
    public class EliminarStaffHandler : IRequestHandler<EliminarStaffCommand, bool>
    {
        private readonly IStaffService _staffService;

        public EliminarStaffHandler(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public async Task<bool> Handle(EliminarStaffCommand request, CancellationToken cancellationToken)
        {
            return await _staffService.EliminarStaffAsync(request.Id);
        }
    }
}
