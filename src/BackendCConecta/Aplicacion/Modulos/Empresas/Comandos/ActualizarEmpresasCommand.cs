using MediatR;
using BackendCConecta.Aplicacion.Modulos.Empresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Comandos
{
    public class ActualizarEmpresasCommand : IRequest<EmpresasDto>
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
