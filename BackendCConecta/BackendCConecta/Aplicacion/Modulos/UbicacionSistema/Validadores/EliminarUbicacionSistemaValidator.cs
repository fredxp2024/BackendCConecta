using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Validadores;

public class EliminarUbicacionSistemaValidator : AbstractValidator<EliminarUbicacionSistemaCommand>
{
    public EliminarUbicacionSistemaValidator()
    {
        RuleFor(x => x.IdUbicacion)
            .GreaterThan(0).WithMessage("El identificador es obligatorio.");
    }
}
