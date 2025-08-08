using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;

public class ActualizarDatosPersonaCommand : IRequest
{
    public int IdDatosUsuario { get; set; }
    public ActualizarDatosPersonaDto Datos { get; set; }

    public ActualizarDatosPersonaCommand(int idDatosUsuario, ActualizarDatosPersonaDto datos)
    {
        IdDatosUsuario = idDatosUsuario;
        Datos = datos;
    }
}
