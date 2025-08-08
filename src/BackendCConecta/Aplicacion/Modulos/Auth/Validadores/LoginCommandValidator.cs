using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Auth.Comandos;


namespace Aplicacion.Modulos.Auth.Validadores;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.CorreoElectronico)
            .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
            .EmailAddress().WithMessage("El correo electrónico no tiene un formato válido.")
            .MaximumLength(100).WithMessage("El correo electrónico no debe exceder los 100 caracteres.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("La contraseña es obligatoria.")
            .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
            .MaximumLength(100).WithMessage("La contraseña no debe exceder los 100 caracteres.")
            .Matches("[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.")
            .Matches("[a-z]").WithMessage("La contraseña debe contener al menos una letra minúscula.")
            .Matches("\\d").WithMessage("La contraseña debe contener al menos un número.")
            .Matches("[\\W_]").WithMessage("La contraseña debe contener al menos un carácter especial.");
    }
}
