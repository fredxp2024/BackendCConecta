using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos
{
    public class EliminarUbicacionSistemaCommand : IRequest
    {
        public int IdUbicacion { get; set; }

        public EliminarUbicacionSistemaCommand(int idUbicacion)
        {
            IdUbicacion = idUbicacion;
        }
    }
}
