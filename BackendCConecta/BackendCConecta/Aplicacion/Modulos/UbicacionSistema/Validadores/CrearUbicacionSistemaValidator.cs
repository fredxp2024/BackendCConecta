using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Validadores;

public class CrearUbicacionSistemaValidator : AbstractValidator<CrearUbicacionSistemaCommand>
{
    public CrearUbicacionSistemaValidator()
    {
        RuleFor(x => x.Pais)
            .NotEmpty().WithMessage("El país es obligatorio.");
    }
}
