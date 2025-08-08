using FluentValidation;
using BackendCConecta.Aplicacion.Modulos.Publicaciones.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Publicaciones.Validadores
{
    public class CambiarEstadoPublicacionesValidator : AbstractValidator<CambiarEstadoPublicacionesCommand>
    {
        public CambiarEstadoPublicacionesValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("El id es obligatorio.");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("El estado es obligatorio.");
        }
    }
}
