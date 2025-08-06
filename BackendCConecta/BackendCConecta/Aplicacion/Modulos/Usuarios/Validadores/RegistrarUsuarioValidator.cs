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
                .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres.");

            RuleFor(x => x.TipoAcceso)
                .NotEmpty().WithMessage("El tipo de acceso es obligatorio.")
                .Must(ReglasUsuario.EsTipoAccesoValido).WithMessage("Tipo de acceso no válido.");
        }
    }
}
