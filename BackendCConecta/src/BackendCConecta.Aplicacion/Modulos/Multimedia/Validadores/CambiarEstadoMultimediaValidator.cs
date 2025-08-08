using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Multimedia.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Multimedia.Validadores
{
    public class CambiarEstadoMultimediaValidator : AbstractValidator<CambiarEstadoMultimediaCommand>
    {
        public CambiarEstadoMultimediaValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
