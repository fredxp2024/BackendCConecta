using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Validadores;

public class CrearDatosUsuarioValidator : AbstractValidator<CrearDatosUsuarioCommand>
{
    public CrearDatosUsuarioValidator()
    {
        RuleFor(x => x.IdUsuario)
            .GreaterThan(0).WithMessage("El IdUsuario debe ser mayor que cero.");
        RuleFor(x => x.TipoUsuario)
            .NotEmpty().WithMessage("El tipo de usuario es obligatorio.");
    }
}
