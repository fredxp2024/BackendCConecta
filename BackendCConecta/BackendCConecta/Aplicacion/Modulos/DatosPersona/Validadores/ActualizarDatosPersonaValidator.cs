using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosPersona.Validadores;

public class ActualizarDatosPersonaValidator : AbstractValidator<ActualizarDatosPersonaCommand>
{
    public ActualizarDatosPersonaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
        RuleFor(x => x.Datos).NotNull();
        RuleFor(x => x.Datos.Nombres)
            .NotEmpty().WithMessage("El nombre es obligatorio.");
        RuleFor(x => x.Datos.ApellidoPaterno)
            .NotEmpty().WithMessage("El apellido paterno es obligatorio.");
    }
}
