using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;

public class EliminarDatosPersonaCommand : IRequest
{
    public int IdDatosUsuario { get; set; }

    public EliminarDatosPersonaCommand(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
