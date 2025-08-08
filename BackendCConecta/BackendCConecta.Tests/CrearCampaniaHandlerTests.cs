using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Campanias.Comandos;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Handlers;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Campanias.Profiles;
using Moq;
using Xunit;

namespace BackendCConecta.Tests;

public class CrearCampaniaHandlerTests
{
    [Fact]
    public async Task Handle_DelegatesToService()
    {
        var service = new Mock<ICampaniaCommandService>();
        service.Setup(s => s.CrearCampaniaAsync(It.IsAny<CampaniaDTO>())).ReturnsAsync(1);

        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<CampaniaProfile>());
        var mapper = mapperConfig.CreateMapper();

        var handler = new CrearCampaniaHandler(service.Object, mapper);
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

