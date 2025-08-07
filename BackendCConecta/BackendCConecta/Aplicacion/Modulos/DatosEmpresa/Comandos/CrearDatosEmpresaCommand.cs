using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;

public class CrearDatosEmpresaCommand : IRequest<int>
{
    public CrearDatosEmpresaDto Datos { get; set; }

    public CrearDatosEmpresaCommand(CrearDatosEmpresaDto datos)
    {
        Datos = datos;
    }
}
