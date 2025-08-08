using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Handlers
{
    public class ActualizarEmpresasHandler : IRequestHandler<ActualizarEmpresasCommand, EmpresasDto>
    {
        private readonly IEmpresasService _empresasService;

        public ActualizarEmpresasHandler(IEmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        public async Task<EmpresasDto> Handle(ActualizarEmpresasCommand request, CancellationToken cancellationToken)
        {
            return await _empresasService.ActualizarEmpresasAsync(request);
        }
    }
}
