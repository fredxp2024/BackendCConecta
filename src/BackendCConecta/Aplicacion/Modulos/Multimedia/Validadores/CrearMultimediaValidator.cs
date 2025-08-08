using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Validadores
{
    public class CrearMultimediaValidator : AbstractValidator<CrearMultimediaCommand>
    {
        public CrearMultimediaValidator()
        {
            RuleFor(x => x.Url).NotEmpty().WithMessage("La url es obligatoria.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
