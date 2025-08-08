using System.Threading;
using System.Threading.Tasks;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Handlers
{
    public class CrearEmpresasHandler : IRequestHandler<CrearEmpresasCommand, EmpresasDto>
    {
        private readonly IEmpresasService _empresasService;

        public CrearEmpresasHandler(IEmpresasService empresasService)
        {
            _empresasService = empresasService;
        }

        public async Task<EmpresasDto> Handle(CrearEmpresasCommand request, CancellationToken cancellationToken)
        {
            return await _empresasService.CrearEmpresasAsync(request);
        }
    }
}
