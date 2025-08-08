using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Validadores;

public class EliminarDatosEmpresaValidator : AbstractValidator<EliminarDatosEmpresaCommand>
{
    public EliminarDatosEmpresaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
    }
}
