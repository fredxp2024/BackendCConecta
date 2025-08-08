using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Validadores;

public class EliminarDatosUsuarioValidator : AbstractValidator<EliminarDatosUsuarioCommand>
{
    public EliminarDatosUsuarioValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
    }
}
