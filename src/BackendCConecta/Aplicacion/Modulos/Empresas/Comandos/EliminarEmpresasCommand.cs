using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Empresas.Comandos
{
    public class EliminarEmpresasCommand : IRequest<bool>
    {
        public int IdEmpresa { get; set; }
    }
}
