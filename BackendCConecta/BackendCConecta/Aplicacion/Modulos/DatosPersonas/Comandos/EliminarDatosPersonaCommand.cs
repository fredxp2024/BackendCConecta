using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;

public class EliminarDatosPersonaCommand : IRequest<Unit>
{
    public int IdDatosUsuario { get; set; }

    public EliminarDatosPersonaCommand(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
