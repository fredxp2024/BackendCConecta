using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Validadores;

public class ActualizarDatosUsuarioValidator : AbstractValidator<ActualizarDatosUsuarioCommand>
{
    public ActualizarDatosUsuarioValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
        RuleFor(x => x.TipoUsuario)
            .NotEmpty().WithMessage("El tipo de usuario es obligatorio.");
    }
}
