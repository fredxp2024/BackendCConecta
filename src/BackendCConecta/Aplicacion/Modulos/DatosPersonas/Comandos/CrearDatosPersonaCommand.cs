using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;

public class CrearDatosPersonaCommand : IRequest<int>
{
    public CrearDatosPersonaDto Datos { get; set; }

    public CrearDatosPersonaCommand(CrearDatosPersonaDto datos)
    {
        Datos = datos;
    }
}
