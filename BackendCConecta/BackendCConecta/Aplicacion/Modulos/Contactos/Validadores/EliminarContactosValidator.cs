using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Validadores;

public class EliminarContactosValidator : AbstractValidator<EliminarContactosCommand>
{
    public EliminarContactosValidator()
    {
        RuleFor(x => x.IdContacto).GreaterThan(0);
    }
}
