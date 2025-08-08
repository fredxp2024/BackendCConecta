using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Contactos.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Contactos.Validadores;

public class CrearContactosValidator : AbstractValidator<CrearContactosCommand>
{
    public CrearContactosValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio.");
        RuleFor(x => x.Telefono).NotEmpty().WithMessage("El teléfono es obligatorio.");
        RuleFor(x => x.Correo).NotEmpty().WithMessage("El correo es obligatorio.");
    }
}
