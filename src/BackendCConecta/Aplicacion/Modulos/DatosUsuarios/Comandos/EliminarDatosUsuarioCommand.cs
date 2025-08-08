using MediatR;


namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos
{
    public class EliminarDatosUsuarioCommand : IRequest<bool>
    {
        public int IdDatosUsuario { get; set; }
    }
}
