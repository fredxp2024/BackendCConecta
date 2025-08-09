using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;

public class EliminarDatosEmpresaCommand : IRequest<Unit>
{
    public int IdDatosUsuario { get; set; }

    public EliminarDatosEmpresaCommand(int idDatosUsuario)
    {
        IdDatosUsuario = idDatosUsuario;
    }
}
