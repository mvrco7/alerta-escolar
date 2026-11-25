using AlertaEscolar.Api.Data;
using AlertaEscolar.Shared.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// CONFIGURACION DE BASE DE DATOS SQLITE
builder.Services.AddDbContext<AlertaEscolarDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("ConexionSQLite")));

// CONFIGURACION JWT
var jwtKey = builder.Configuration["Jwt:Key"];
var jwtIssuer = builder.Configuration["Jwt:Issuer"];
var jwtAudience = builder.Configuration["Jwt:Audience"];

if (string.IsNullOrWhiteSpace(jwtKey) ||
    Encoding.UTF8.GetByteCount(jwtKey) < 32)
{
    throw new InvalidOperationException(
        "Configura Jwt:Key con una clave de al menos 32 bytes.");
}

if (string.IsNullOrWhiteSpace(jwtIssuer) ||
    string.IsNullOrWhiteSpace(jwtAudience))
{
    throw new InvalidOperationException(
        "Debes configurar Jwt:Issuer y Jwt:Audience.");
}

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters =
            new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,

                ValidIssuer = jwtIssuer,
                ValidAudience = jwtAudience,

                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtKey)),

                ClockSkew = TimeSpan.FromMinutes(1)
            };
    });

// SERVICIOS DE LA API
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddAuthorization();

var app = builder.Build();

// CREAR ADMINISTRADOR DE DESARROLLO
if (app.Environment.IsDevelopment())
{
    string? adminNombre = app.Configuration["Admin:Nombre"];
    string? adminCorreo = app.Configuration["Admin:Correo"];
    string? adminPassword = app.Configuration["Admin:Password"];

    if (!string.IsNullOrWhiteSpace(adminNombre) &&
        !string.IsNullOrWhiteSpace(adminCorreo) &&
        !string.IsNullOrWhiteSpace(adminPassword) &&
        adminPassword.Length >= 12)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider
            .GetRequiredService<AlertaEscolarDbContext>();

        adminCorreo = adminCorreo.Trim().ToLowerInvariant();

        var usuarioExistente = await context.Usuarios
            .FirstOrDefaultAsync(u => u.Correo == adminCorreo);

        if (usuarioExistente == null)
        {
            var administrador = new Usuario
            {
                Nombre = adminNombre.Trim(),
                Correo = adminCorreo,
                Rol = "Administrador",
                Activo = true
            };

            var passwordHasher = new PasswordHasher<Usuario>();

            administrador.PasswordHash =
                passwordHasher.HashPassword(
                    administrador,
                    adminPassword);

            context.Usuarios.Add(administrador);

            await context.SaveChangesAsync();

            app.Logger.LogInformation(
                "Administrador de desarrollo creado correctamente.");
        }
        else if (usuarioExistente.Rol == "Administrador" &&
                 usuarioExistente.Activo)
        {
            app.Logger.LogInformation(
                "La cuenta de administrador ya existe.");
        }
        else
        {
            app.Logger.LogWarning(
                "El correo configurado pertenece a una cuenta " +
                "que no es un administrador activo.");
        }
    }
    else
    {
        app.Logger.LogWarning(
            "Configuracion del administrador de desarrollo " +
            "ausente o incompleta.");
    }
}

// CONFIGURACION HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// AUTENTICACION ANTES DE AUTORIZACION
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();