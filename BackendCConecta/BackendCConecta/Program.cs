using System.Security.Claims;
using System.Text;
using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using BackendCConecta.Api.Middlewares;
using BackendCConecta.Aplicacion.Comportamientos;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Auth.Servicios;
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Campanias.Services;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Services;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;
using BackendCConecta.Infraestructura.Repositorios;
using BackendCConecta.Infraestructura.Repositorios.DatosEmpresas;
using BackendCConecta.Infraestructura.Repositorios.DatosPersonas;
using BackendCConecta.Infraestructura.Repositorios.DatosUsuarios;
using BackendCConecta.Infraestructura.Repositorios.Ubicaciones;
using BackendCConecta.Infraestructura.Repositorios.Usuarios;
using BackendCConecta.Infraestructura.Seguridad;
using BackendCConecta.Infraestructura.Servicios;
using BackendCConecta.Infraestructura.Servicios.DatosEmpresas;
using BackendCConecta.Infraestructura.Servicios.DatosPersonas;
using BackendCConecta.Infraestructura.Servicios.DatosUsuarios;
using BackendCConecta.Infraestructura.Servicios.Usuarios;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sql => sql.EnableRetryOnFailure()
    )
);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(
        typeof(BackendCConecta.Aplicacion.AssemblyMarker).Assembly,
        typeof(Program).Assembly
    );
});

builder.Services.AddControllers();
builder.Services
    .AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblies(new[]
{
    typeof(BackendCConecta.Aplicacion.AssemblyMarker).Assembly
});

builder.Services.AddAutoMapper(
    typeof(BackendCConecta.Aplicacion.AssemblyMarker).Assembly
);

builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IFileStorageService, FileStorageService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioCommandService, UsuarioCommandService>();
builder.Services.AddScoped<IUsuarioQueryService, UsuarioQueryService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
builder.Services.AddScoped<IDatosUsuarioRepository, DatosUsuarioRepository>();
builder.Services.AddScoped<IDatosUsuarioQueryService, DatosUsuarioQueryService>();
builder.Services.AddScoped<IDatosPersonaRepository, DatosPersonaRepository>();
builder.Services.AddScoped<IDatosPersonaQueryService, DatosPersonaQueryService>();
builder.Services.AddScoped<IDatosEmpresaRepository, DatosEmpresaRepository>();
builder.Services.AddScoped<IDatosEmpresaQueryService, DatosEmpresaQueryService>();
builder.Services.AddScoped<IUbicacionesSistemaRepository, UbicacionSistemaRepository>();
builder.Services.AddScoped<ICampaniaCommandService, CampaniaService>();
builder.Services.AddScoped<ICampaniaQueryService, CampaniaService>();
builder.Services.AddScoped<IFechasImportantesService, FechasImportantesService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opts =>
    {
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
            )
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrador", policy => policy.RequireClaim(ClaimTypes.Role, "administrador"));
    options.AddPolicy("Colaborador", policy => policy.RequireClaim(ClaimTypes.Role, "colaborador"));
    options.AddPolicy("Usuario", policy => policy.RequireClaim(ClaimTypes.Role, "usuario"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Default", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

