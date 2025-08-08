using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Comandos
{
    public class CrearEmpresasCommand : IRequest<EmpresasDto>
    {
        public string Nombre { get; set; } = null!;
    }
}
