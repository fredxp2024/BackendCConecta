using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Validadores;

public class ActualizarContactosValidator : AbstractValidator<ActualizarContactosCommand>
{
    public ActualizarContactosValidator()
    {
        RuleFor(x => x.IdContacto).GreaterThan(0);
    }
}
