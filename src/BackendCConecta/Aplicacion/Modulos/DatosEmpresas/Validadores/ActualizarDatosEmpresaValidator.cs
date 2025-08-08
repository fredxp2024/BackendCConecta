using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Validadores;

public class ActualizarDatosEmpresaValidator : AbstractValidator<ActualizarDatosEmpresaCommand>
{
    public ActualizarDatosEmpresaValidator()
    {
        RuleFor(x => x.IdDatosUsuario)
            .GreaterThan(0).WithMessage("El IdDatosUsuario debe ser mayor que cero.");
        RuleFor(x => x.Datos).NotNull();
        RuleFor(x => x.Datos.RazonSocial)
            .NotEmpty().WithMessage("La razón social es obligatoria.");
    }
}
