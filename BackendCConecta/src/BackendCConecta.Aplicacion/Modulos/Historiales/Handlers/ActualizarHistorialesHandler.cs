using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;
using BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Handlers
{
    public class ActualizarHistorialesHandler : IRequestHandler<ActualizarHistorialesCommand, HistorialesDto>
    {
        private readonly IHistorialesService _historialesService;

        public ActualizarHistorialesHandler(IHistorialesService historialesService)
        {
            _historialesService = historialesService;
        }

        public async Task<HistorialesDto> Handle(ActualizarHistorialesCommand request, CancellationToken cancellationToken)
        {
            return await _historialesService.ActualizarHistorialAsync(request);
        }
    }
}
