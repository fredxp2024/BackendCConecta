using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Validadores;

public class CrearDatosEmpresaValidator : AbstractValidator<CrearDatosEmpresaCommand>
{
    public CrearDatosEmpresaValidator()
    {
        RuleFor(x => x.Datos).NotNull();
        RuleFor(x => x.Datos.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
        RuleFor(x => x.Datos.RazonSocial)
            .NotEmpty().WithMessage("La razón social es obligatoria.");
        RuleFor(x => x.Datos.Ruc)
            .NotEmpty().WithMessage("El RUC es obligatorio.");
    }
}
