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
                .Must(ReglasUsuario.EsCorreoValido).WithMessage("El correo no es válido.");

            RuleFor(x => x.TipoAcceso)
                .NotEmpty().WithMessage("El tipo de acceso es obligatorio.")
                .Must(ReglasUsuario.EsTipoAccesoValido).WithMessage("Tipo de acceso no válido.");
        }
    }
}
