using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Validadores;

public class EliminarUbicacionSistemaValidator : AbstractValidator<EliminarUbicacionSistemaCommand>
{
    public EliminarUbicacionSistemaValidator()
    {
        RuleFor(x => x.IdUbicacion)
            .GreaterThan(0).WithMessage("El identificador es obligatorio.");
    }
}
