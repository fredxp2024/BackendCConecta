using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Utilidades;

namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Validadores
{
    public class ActualizarUsuarioValidator : AbstractValidator<ActualizarUsuarioCommand>
    {
        public ActualizarUsuarioValidator()
        {
            RuleFor(x => x.IdUsuario)
                .GreaterThan(0).WithMessage("El ID de usuario debe ser mayor a 0.");

            RuleFor(x => x.CorreoElectronico)
                .NotEmpty().WithMessage("El correo es obligatorio.")
                .Must(c => !string.IsNullOrWhiteSpace(c) && ReglasUsuario.EsCorreoValido(c!))
                .WithMessage("El correo no es válido.");

            RuleFor(x => x.TipoAcceso)
                .NotEmpty().WithMessage("El tipo de acceso es obligatorio.")
                .Must(t => !string.IsNullOrWhiteSpace(t) && ReglasUsuario.EsTipoAccesoValido(t!))
                .WithMessage("Tipo de acceso no válido.");
        }
    }
}
