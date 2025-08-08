using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Validadores;

public class ActualizarUbicacionSistemaValidator : AbstractValidator<ActualizarUbicacionSistemaCommand>
{
    public ActualizarUbicacionSistemaValidator()
    {
        RuleFor(x => x.IdUbicacion)
            .GreaterThan(0).WithMessage("El identificador es obligatorio.");

        RuleFor(x => x.Pais)
            .NotEmpty().WithMessage("El país es obligatorio.");

        RuleFor(x => x.Latitud)
            .InclusiveBetween(-90, 90)
            .When(x => x.Latitud.HasValue)
            .WithMessage("La latitud debe estar entre -90 y 90 grados.");

        RuleFor(x => x.Longitud)
            .InclusiveBetween(-180, 180)
            .When(x => x.Longitud.HasValue)
            .WithMessage("La longitud debe estar entre -180 y 180 grados.");
    }
}
