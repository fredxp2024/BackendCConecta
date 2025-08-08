using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Validadores;

public class CrearCampaniaValidator : AbstractValidator<CrearCampaniaCommand>
{
    public CrearCampaniaValidator()
    {
        RuleFor(x => x.Titulo)
            .NotEmpty();

        RuleFor(x => x.TipoCampania)
            .NotEmpty();

        RuleFor(x => x.FechaInicio)
            .NotEmpty()
            .LessThan(x => x.FechaFin);

        RuleFor(x => x.FechaFin)
            .NotEmpty()
            .GreaterThan(x => x.FechaInicio);

        RuleFor(x => x.IdStaff)
            .GreaterThan(0);
    }
}
