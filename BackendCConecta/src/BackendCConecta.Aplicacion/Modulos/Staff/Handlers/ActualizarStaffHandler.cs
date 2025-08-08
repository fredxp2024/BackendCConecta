using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Staff.Comandos;
using BackendCConecta.Aplicacion.Modulos.Staff.DTOs;
using BackendCConecta.Aplicacion.Modulos.Staff.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Staff.Handlers
{
    public class ActualizarStaffHandler : IRequestHandler<ActualizarStaffCommand, StaffDto>
    {
        private readonly IStaffService _staffService;

        public ActualizarStaffHandler(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public async Task<StaffDto> Handle(ActualizarStaffCommand request, CancellationToken cancellationToken)
        {
            return await _staffService.ActualizarStaffAsync(request);
        }
    }
}
