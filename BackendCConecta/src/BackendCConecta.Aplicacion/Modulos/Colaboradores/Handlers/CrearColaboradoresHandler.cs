using MediatR;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Comandos;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.DTOs;
using BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Colaboradores.Handlers
{
    public class CrearColaboradoresHandler : IRequestHandler<CrearColaboradoresCommand, ColaboradoresDto>
    {
        private readonly IColaboradoresService _colaboradoresService;

        public CrearColaboradoresHandler(IColaboradoresService colaboradoresService)
        {
            _colaboradoresService = colaboradoresService;
        }

        public async Task<ColaboradoresDto> Handle(CrearColaboradoresCommand request, CancellationToken cancellationToken)
        {
            return await _colaboradoresService.CrearColaboradorAsync(request);
        }
    }
}
