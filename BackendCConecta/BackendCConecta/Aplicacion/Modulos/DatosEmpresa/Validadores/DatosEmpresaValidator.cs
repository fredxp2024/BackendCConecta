using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Validadores;

public class DatosEmpresaValidator : AbstractValidator<CrearDatosEmpresaDto>
{
    public DatosEmpresaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");

        RuleFor(x => x.RazonSocial)
            .NotEmpty().WithMessage("La razón social es obligatoria.")
            .MaximumLength(200);

        RuleFor(x => x.Ruc)
            .MaximumLength(20)
            .When(x => !string.IsNullOrWhiteSpace(x.Ruc));

        RuleFor(x => x.PaginaWeb)
            .MaximumLength(200)
            .When(x => !string.IsNullOrWhiteSpace(x.PaginaWeb));
    }
}
