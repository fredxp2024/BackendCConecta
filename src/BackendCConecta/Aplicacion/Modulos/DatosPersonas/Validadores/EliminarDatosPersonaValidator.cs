using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Validadores;

public class EliminarDatosPersonaValidator : AbstractValidator<EliminarDatosPersonaCommand>
{
    public EliminarDatosPersonaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
    }
}
