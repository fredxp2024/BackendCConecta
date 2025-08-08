using MediatR;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;

public class CrearDatosEmpresaCommand : IRequest<int>
{
    public CrearDatosEmpresaDto Datos { get; set; }

    public CrearDatosEmpresaCommand(CrearDatosEmpresaDto datos)
    {
        Datos = datos;
    }
}
