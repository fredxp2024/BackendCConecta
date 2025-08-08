using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Validadores;

public class ActualizarFechasImportantesValidator : AbstractValidator<ActualizarFechasImportantesCommand>
{
    public ActualizarFechasImportantesValidator()
    {
        RuleFor(x => x.IdFechaImportante).GreaterThan(0);
        RuleFor(x => x.Titulo).NotEmpty();
        RuleFor(x => x.Fecha).NotEmpty();
    }
}
