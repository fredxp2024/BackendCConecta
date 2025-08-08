using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Validadores
{
    public class CrearPublicacionesValidator : AbstractValidator<CrearPublicacionesCommand>
    {
        public CrearPublicacionesValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("El titulo es obligatorio.");
            RuleFor(x => x.Contenido).NotEmpty().WithMessage("El contenido es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
