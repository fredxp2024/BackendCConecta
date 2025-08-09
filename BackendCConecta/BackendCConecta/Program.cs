using System.Security.Claims;
using System.Text;
using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using BackendCConecta.Aplicacion;
using BackendCConecta.Infraestructura;
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
using BackendCConecta.Aplicacion.Modulos.Staff.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Staff.Servicios;
using BackendCConecta.Dominio.Entidades.Usuarios;
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
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseDefaultServiceProvider(o =>
{
    o.ValidateOnBuild = true;
    o.ValidateScopes = true;
});

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
builder.Services.AddScoped<IPasswordHasher<Usuario>, PasswordHasher<Usuario>>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICampaniaCommandService, CampaniaService>();
builder.Services.AddScoped<ICampaniaQueryService, CampaniaService>();
builder.Services.AddScoped<IFechasImportantesService, FechasImportantesService>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));

builder.Services.Scan(scan => scan
    .FromAssemblies(
        typeof(BackendCConecta.Infraestructura.AssemblyMarker).Assembly,
        typeof(BackendCConecta.Aplicacion.AssemblyMarker).Assembly)
    // Servicios de dominio / aplicación implementados en Infraestructura.Servicios...
    .AddClasses(c => c.InNamespaces(
        "BackendCConecta.Infraestructura.Servicios",
        "BackendCConecta.Infraestructura.Servicios.Usuarios",
        "BackendCConecta.Infraestructura.Servicios.Contactos",
        "BackendCConecta.Infraestructura.Servicios.Colaboradores",
        "BackendCConecta.Infraestructura.Servicios.Acuerdos",
        "BackendCConecta.Infraestructura.Servicios.Publicaciones",
        "BackendCConecta.Infraestructura.Servicios.Paquetes",
        "BackendCConecta.Infraestructura.Servicios.Multimedia",
        "BackendCConecta.Infraestructura.Servicios.Intereses",
        "BackendCConecta.Infraestructura.Servicios.Historiales",
        "BackendCConecta.Infraestructura.Servicios.Empresas",
        "BackendCConecta.Infraestructura.Servicios.Roles",
        "BackendCConecta.Infraestructura.Servicios.Staff"))
        .AsImplementedInterfaces()
        .WithScopedLifetime()

    // Repositorios implementados en Infraestructura.Repositorios...
    .AddClasses(c => c.InNamespaces(
        "BackendCConecta.Infraestructura.Repositorios",
        "BackendCConecta.Infraestructura.Repositorios.DatosUsuarios",
        "BackendCConecta.Infraestructura.Repositorios.DatosPersonas",
        "BackendCConecta.Infraestructura.Repositorios.DatosEmpresas",
        "BackendCConecta.Infraestructura.Repositorios.Usuarios",
        "BackendCConecta.Infraestructura.Repositorios.Ubicaciones",
        "BackendCConecta.Infraestructura.Repositorios.Publicaciones",
        "BackendCConecta.Infraestructura.Repositorios.Paquetes",
        "BackendCConecta.Infraestructura.Repositorios.Multimedia",
        "BackendCConecta.Infraestructura.Repositorios.Intereses",
        "BackendCConecta.Infraestructura.Repositorios.Historiales",
        "BackendCConecta.Infraestructura.Repositorios.Empresas",
        "BackendCConecta.Infraestructura.Repositorios.Roles",
        "BackendCConecta.Infraestructura.Repositorios.Staff"))
        .AsImplementedInterfaces()
        .WithScopedLifetime()
);

// Registros explícitos de respaldo
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Contactos.Interfaces.IContactosService,
                           BackendCConecta.Aplicacion.Modulos.Contactos.Servicios.ContactosService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Colaboradores.Interfaces.IColaboradoresService,
                           BackendCConecta.Aplicacion.Modulos.Colaboradores.Servicios.ColaboradoresService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces.IAcuerdoCommandService,
                           BackendCConecta.Infraestructura.Servicios.Acuerdos.AcuerdoComercialCommandService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces.IAcuerdoQueryService,
                           BackendCConecta.Infraestructura.Servicios.Acuerdos.AcuerdoComercialQueryService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Publicaciones.Interfaces.IPublicacionesService,
                           BackendCConecta.Aplicacion.Modulos.Publicaciones.Servicios.PublicacionesService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Paquetes.Interfaces.IPaquetesService,
                           BackendCConecta.Aplicacion.Modulos.Paquetes.Servicios.PaquetesService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Multimedia.Interfaces.IMultimediaService,
                           BackendCConecta.Aplicacion.Modulos.Multimedia.Servicios.MultimediaService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Intereses.Interfaces.IInteresesService,
                           BackendCConecta.Aplicacion.Modulos.Intereses.Servicios.InteresesService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Historiales.Interfaces.IHistorialesService,
                           BackendCConecta.Aplicacion.Modulos.Historiales.Servicios.HistorialesService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Empresas.Interfaces.IEmpresasService,
                           BackendCConecta.Aplicacion.Modulos.Empresas.Servicios.EmpresasService>();
builder.Services.AddScoped<BackendCConecta.Aplicacion.Modulos.Roles.Interfaces.IRolCommandService,
                           BackendCConecta.Infraestructura.Servicios.Roles.RolCommandService>();

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opts =>
    {
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidateLifetime = true,
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
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.ExampleFilters();
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API BackendCConecta",
        Version = "v1",
        Description = "Documentación de la API con ASP.NET 8 y Swagger optimizado"
    });

    var jwtScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Esquema JWT usando Bearer. Ejemplo: **Bearer {tu_token_jwt}**",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    };

    options.AddSecurityDefinition("Bearer", jwtScheme);
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtScheme, Array.Empty<string>() }
    });
});

builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());

builder.Services.AddCors(options =>
{
    options.AddPolicy("Default", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

