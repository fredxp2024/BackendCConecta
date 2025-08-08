using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Handlers
{
    public class ActualizarColaboradoresHandler : IRequestHandler<ActualizarColaboradoresCommand, ColaboradoresDto>
    {
        private readonly IColaboradoresService _colaboradoresService;

        public ActualizarColaboradoresHandler(IColaboradoresService colaboradoresService)
        {
            _colaboradoresService = colaboradoresService;
        }

        public async Task<ColaboradoresDto> Handle(ActualizarColaboradoresCommand request, CancellationToken cancellationToken)
        {
            return await _colaboradoresService.ActualizarColaboradorAsync(request);
        }
    }
}
