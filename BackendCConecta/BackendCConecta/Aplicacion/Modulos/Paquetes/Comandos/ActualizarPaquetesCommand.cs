using MediatR;
using BackendCConecta.Aplicacion.Modulos.Paquetes.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.Paquetes.Comandos
{
    public class ActualizarPaquetesCommand : IRequest<PaquetesDto>
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
    }
}
