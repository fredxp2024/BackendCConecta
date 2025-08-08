using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersonas.Validadores;

public class CrearDatosPersonaValidator : AbstractValidator<CrearDatosPersonaCommand>
{
    public CrearDatosPersonaValidator()
    {
        RuleFor(x => x.Datos).NotNull();
        RuleFor(x => x.Datos.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
        RuleFor(x => x.Datos.Nombres)
            .NotEmpty().WithMessage("El nombre es obligatorio.");
        RuleFor(x => x.Datos.ApellidoPaterno)
            .NotEmpty().WithMessage("El apellido paterno es obligatorio.");
    }
}
