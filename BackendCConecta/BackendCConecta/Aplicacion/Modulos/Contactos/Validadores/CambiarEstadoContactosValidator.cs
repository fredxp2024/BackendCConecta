using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Validadores;

public class CambiarEstadoContactosValidator : AbstractValidator<CambiarEstadoContactosCommand>
{
    public CambiarEstadoContactosValidator()
    {
        RuleFor(x => x.IdContacto).GreaterThan(0);
        RuleFor(x => x.Estado).NotEmpty();
    }
}
