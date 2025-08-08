using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Utilidades;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Validadores
{
    public class RegistrarUsuarioValidator : AbstractValidator<RegistrarUsuarioCommand>
    {
        public RegistrarUsuarioValidator()
        {
            RuleFor(x => x.CorreoElectronico)
                .NotEmpty().WithMessage("El correo es obligatorio.")
                .Must(ReglasUsuario.EsCorreoValido).WithMessage("El correo no es válido.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches("[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.")
                .Matches("[a-z]").WithMessage("La contraseña debe contener al menos una letra minúscula.")
                .Matches("\\d").WithMessage("La contraseña debe contener al menos un número.")
                .Matches("[\\W_]").WithMessage("La contraseña debe contener al menos un carácter especial.");

            RuleFor(x => x.TipoAcceso)
                .NotEmpty().WithMessage("El tipo de acceso es obligatorio.")
                .Must(ReglasUsuario.EsTipoAccesoValido).WithMessage("Tipo de acceso no válido.");
        }
    }
}
