using System.Reflection;
using System.Text;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

using BackendCConecta.Aplicacion.InterfacesGenerales;// o donde esté IUsuarioService
using BackendCConecta.Infraestructura.Servicios;// o donde esté UsuarioService

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

// ?? DatosUsuario

using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.validadores;

// ?? DatosPersona
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Interfaces;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Validadores;
using BackendCConecta.Infraestructura.Servicios.DatosPersona;

using BackendCConecta.Infraestructura.Repositorios.DatosUsuarios;
using BackendCConecta.Infraestructura.Repositorios.DatosPersona;





var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

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
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = config["Jwt:Issuer"],
        ValidAudience = config["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]))
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
// 🗂️ FluentValidation
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

// 🧠 MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// ---------------------------------------------
// 🔐 Autorización general
// ---------------------------------------------
builder.Services.AddAuthorization();

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

// 🔐 Seguridad
app.UseAuthentication(); // Siempre antes de Authorization
app.UseAuthorization();

// 🌐 Endpoints
app.MapControllers();

// 🚀 Ejecuta la app
app.Run();


