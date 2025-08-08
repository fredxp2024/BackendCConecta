using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Validadores;

public class DatosPersonaValidator : AbstractValidator<CrearDatosPersonaDto>
{
    public DatosPersonaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");

        RuleFor(x => x.Nombres)
            .NotEmpty().WithMessage("El nombre es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.ApellidoPaterno)
            .NotEmpty().WithMessage("El apellido paterno es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.ApellidoMaterno)
            .MaximumLength(100)
            .When(x => !string.IsNullOrWhiteSpace(x.ApellidoMaterno));

        RuleFor(x => x.Dni)
            .MaximumLength(20)
            .When(x => !string.IsNullOrWhiteSpace(x.Dni));
    }
}
