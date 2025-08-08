using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.FechasImportantes.Validadores;

public class CrearFechasImportantesValidator : AbstractValidator<CrearFechasImportantesCommand>
{
    public CrearFechasImportantesValidator()
    {
        RuleFor(x => x.Titulo).NotEmpty();
        RuleFor(x => x.Fecha).NotEmpty();
    }
}
