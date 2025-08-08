using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Comandos
{
    public class CambiarEstadoEmpresasCommand : IRequest<bool>
    {
        public int IdEmpresa { get; set; }
        public string Estado { get; set; } = null!;
    }
}
