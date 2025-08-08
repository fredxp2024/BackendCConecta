using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using Moq;
using Xunit;

namespace BackendCConecta.Tests;

public class CrearCampaniaHandlerTests
{
    [Fact]
    public async Task Handle_DelegatesToService()
    {
        var service = new Mock<ICampaniaService>();
        service.Setup(s => s.CrearCampaniaAsync(It.IsAny<CampaniaDTO>())).ReturnsAsync(1);

        var handler = new CrearCampaniaHandler(service.Object);
        var command = new CrearCampaniaCommand
        {
            Titulo = "Prueba",
            TipoCampania = "Tipo",
            FechaInicio = DateOnly.FromDateTime(DateTime.UtcNow),
            FechaFin = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(1)),
            IdStaff = 1
        };

        var result = await handler.Handle(command, CancellationToken.None);

        Assert.Equal(1, result);
        service.Verify(s => s.CrearCampaniaAsync(It.IsAny<CampaniaDTO>()), Times.Once);
    }
}

