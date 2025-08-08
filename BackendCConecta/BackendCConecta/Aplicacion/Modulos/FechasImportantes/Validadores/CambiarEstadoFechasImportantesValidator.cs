using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Validadores;

public class CambiarEstadoFechasImportantesValidator : AbstractValidator<CambiarEstadoFechasImportantesCommand>
{
    public CambiarEstadoFechasImportantesValidator()
    {
        RuleFor(x => x.IdFechaImportante).GreaterThan(0);
    }
}
