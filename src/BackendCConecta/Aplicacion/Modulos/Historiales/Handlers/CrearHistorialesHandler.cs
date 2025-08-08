using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Historiales.Comandos;
using BackendCConecta.Aplicacion.Modulos.Historiales.DTOs;
using BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Historiales.Handlers
{
    public class CrearHistorialesHandler : IRequestHandler<CrearHistorialesCommand, HistorialesDto>
    {
        private readonly IHistorialesService _historialesService;

        public CrearHistorialesHandler(IHistorialesService historialesService)
        {
            _historialesService = historialesService;
        }

        public async Task<HistorialesDto> Handle(CrearHistorialesCommand request, CancellationToken cancellationToken)
        {
            return await _historialesService.CrearHistorialAsync(request);
        }
    }
}
