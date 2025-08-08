using System.Reflection;
using System.Text;
using System.Security.Claims;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;

using BackendCConecta.Aplicacion.Comportamientos;
using BackendCConecta.Aplicacion.InterfacesGenerales;// o donde esté IUsuarioService
using BackendCConecta.Infraestructura.Servicios;// o donde esté UsuarioService

// 📆 Campañas
using BackendCConecta.Aplicacion.Modulos.Campanias.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Campanias.Services;

// 📅 Fechas Importantes
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Interfaces;
using BackendCConecta.Aplicacion.Modulos.FechasImportantes.Services;

// ?? Autenticación
using BackendCConecta.Aplicacion.Modulos.Auth.Interfaces;
using BackendCConecta.Aplicacion.Modulos.Auth.Servicios;
using BackendCConecta.Infraestructura.Seguridad;
  


// ?? Contexto de base de datos
using BackendCConecta.Infraestructura.Persistencia;

// ?? Usuarios
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using BackendCConecta.Infraestructura.Servicios.Usuarios;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Repositorios.Usuarios;
using BackendCConecta.Infraestructura.Repositorios;

// ?? DatosUsuario

using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Validadores;

// ?? DatosPersona
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersonas.Validadores;
using BackendCConecta.Infraestructura.Servicios.DatosPersonas;
using BackendCConecta.Infraestructura.Servicios.DatosUsuarios;

using BackendCConecta.Infraestructura.Repositorios.DatosUsuarios;
using BackendCConecta.Infraestructura.Repositorios.DatosPersonas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Validadores;
using BackendCConecta.Infraestructura.Repositorios.DatosEmpresas;
using BackendCConecta.Infraestructura.Servicios.DatosEmpresas;
using BackendCConecta.Api.Middlewares;
using BackendCConecta.Api.Seguridad;





var builder = WebApplication.CreateBuilder(args);
// 🔐 Carga explícita de secrets.json
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddUserSecrets<Program>() // ⬅️ Esto carga el secrets.json
    .AddEnvironmentVariables();
var config = builder.Configuration;

// 🔐 Configuración de JwtSettings con validación
builder.Services.AddOptions<JwtSettings>()
    .Bind(config.GetSection("Jwt"))
    .Validate(options => !string.IsNullOrEmpty(options.Key) && options.Key.Length >= 32,
        "Jwt:Key debe tener al menos 32 caracteres")
    .Validate(options => options.ExpirationMinutes > 0,
        "Jwt:ExpirationMinutes debe ser mayor que cero")
    .ValidateOnStart();

// ---------------------------------------------
// 1. CONFIGURACIÓN DE AUTENTICACIÓN JWT
// ---------------------------------------------

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var jwtSettings = config.GetSection("Jwt").Get<JwtSettings>();
    options.RequireHttpsMetadata = !builder.Environment.IsDevelopment();
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        RoleClaimType = ClaimTypes.Role,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key))
    };
});

// ---------------------------------------------
// 2. INYECCIÓN DE DEPENDENCIAS POR MÓDULO
// ---------------------------------------------



// ---------------------------------------------
// 🗃️ Configuración de DbContext con SQL Server
// ---------------------------------------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("CadenaSQL")));

// ---------------------------------------------
// 💉 Inyección de dependencias (Auth + generales)
// ---------------------------------------------
builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IFileStorageService, FileStorageService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioQueryService, UsuarioQueryService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
builder.Services.AddScoped<IDatosUsuarioRepository, DatosUsuarioRepository>();
builder.Services.AddScoped<IDatosUsuarioQueryService, DatosUsuarioQueryService>();
builder.Services.AddScoped<IDatosPersonaRepository, DatosPersonaRepository>();
builder.Services.AddScoped<IDatosPersonaQueryService, DatosPersonaQueryService>();
builder.Services.AddScoped<IDatosEmpresaRepository, DatosEmpresaRepository>();
builder.Services.AddScoped<IDatosEmpresaQueryService, DatosEmpresaQueryService>();
builder.Services.AddScoped<ICampaniaCommandService, CampaniaService>();
builder.Services.AddScoped<ICampaniaQueryService, CampaniaService>();
builder.Services.AddScoped<IFechasImportantesService, FechasImportantesService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));
// 🗂️ FluentValidation
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

// 🧠 MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// ---------------------------------------------
// 🔐 Autorización general
// ---------------------------------------------
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrador", policy => policy.RequireClaim(ClaimTypes.Role, "administrador"));
    options.AddPolicy("Colaborador", policy => policy.RequireClaim(ClaimTypes.Role, "colaborador"));
    options.AddPolicy("Usuario", policy => policy.RequireClaim(ClaimTypes.Role, "usuario"));
});

// ---------------------------------------------
// 🚀 Otros servicios esenciales
// ---------------------------------------------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// ---------------------------------------------
// 4. CONFIGURACIÓN DE MIDDLEWARE
// ---------------------------------------------

// ---------------------------------------------
// 🚀 Construcción de la app
// ---------------------------------------------

// Construyes la app con los servicios previamente registrados
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Si estás en desarrollo, activa Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

// 🔐 Seguridad
app.UseAuthentication(); // Siempre antes de Authorization
app.UseAuthorization();

// 🌐 Endpoints
app.MapControllers();

// 🚀 Ejecuta la app
app.Run();


