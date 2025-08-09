using MediatR;
using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;

public class RegistrarParticipanteHandler : IRequestHandler<RegistrarParticipanteCommand, Unit>
{
    public Task<Unit> Handle(RegistrarParticipanteCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Unit.Value);
    }
}

