using AutoMapper;
using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using BackendCConecta.Aplicacion.Modulos.Campanias.Services;
using BackendCConecta.Aplicacion.Modulos.Campanias.Profiles;
using BackendCConecta.Dominio.Entidades.Campanias;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BackendCConecta.Tests;

public class CampaniaServiceTests
{
    private static AppDbContext CreateContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        return new AppDbContext(options);
    }

    [Fact]
    public async Task ObtenerCampaniasAsync_ReturnsCampaigns()
    {
        var context = CreateContext();
        context.Campanias.Add(new Campania
        {
            Titulo = "Campaña 1",
            TipoCampania = "Tipo",
            FechaInicio = DateOnly.FromDateTime(DateTime.UtcNow),
            FechaFin = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(1)),
            IdStaff = 1
        });
        context.Campanias.Add(new Campania
        {
            Titulo = "Campaña 2",
            TipoCampania = "Tipo",
            FechaInicio = DateOnly.FromDateTime(DateTime.UtcNow),
            FechaFin = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(1)),
            IdStaff = 1
        });
        await context.SaveChangesAsync();

        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<CampaniaProfile>());
        var mapper = mapperConfig.CreateMapper();
        var service = new CampaniaService(context, mapper);

        var result = await service.ObtenerCampaniasAsync();

        Assert.Equal(2, result.Count);
    }
}

