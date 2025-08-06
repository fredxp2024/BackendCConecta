using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;

public class CrearDatosPersonaCommand : IRequest<int>
{
    public CrearDatosPersonaDto Datos { get; set; }

    public CrearDatosPersonaCommand(CrearDatosPersonaDto datos)
    {
        Datos = datos;
    }
}
