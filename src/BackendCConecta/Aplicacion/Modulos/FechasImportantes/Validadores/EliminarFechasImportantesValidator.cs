using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Validadores;

public class EliminarFechasImportantesValidator : AbstractValidator<EliminarFechasImportantesCommand>
{
    public EliminarFechasImportantesValidator()
    {
        RuleFor(x => x.IdFechaImportante).GreaterThan(0);
    }
}
