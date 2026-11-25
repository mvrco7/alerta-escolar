using AlertaEscolar.Api.Data;
using AlertaEscolar.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace AlertaEscolar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AlertaEscolarDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly PasswordHasher<Usuario> _passwordHasher = new();

        public UsuariosController(
            AlertaEscolarDbContext context,
            IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // CONSULTAR TODOS LOS USUARIOS
        [Authorize(Roles = "Administrador")]
        [HttpGet]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            var usuarios = await _context.Usuarios
                .AsNoTracking()
                .OrderBy(u => u.Id)
                .Select(u => new
                {
                    u.Id,
                    u.Nombre,
                    u.Correo,
                    u.Rol,
                    u.Activo
                })
                .ToListAsync();

            return Ok(usuarios);
        }

        // REGISTRAR UN USUARIO
        [Authorize(Roles = "Administrador")]
        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar(
            [FromBody] RegistrarUsuarioRequest solicitud)
        {
            if (solicitud == null ||
                string.IsNullOrWhiteSpace(solicitud.Nombre) ||
                string.IsNullOrWhiteSpace(solicitud.Correo) ||
                string.IsNullOrWhiteSpace(solicitud.Password) ||
                solicitud.Password.Length < 12)
            {
                return BadRequest(
                    "Nombre, correo y contraseña son obligatorios. " +
                    "La contraseña debe tener al menos 12 caracteres.");
            }

            string correo = solicitud.Correo
                .Trim()
                .ToLowerInvariant();

            bool existe = await _context.Usuarios
                .AnyAsync(u => u.Correo == correo);

            if (existe)
            {
                return Conflict("El correo ya está registrado.");
            }

            var usuario = new Usuario
            {
                Nombre = solicitud.Nombre.Trim(),
                Correo = correo,
                Rol = "Encargado de Convivencia Escolar",
                Activo = true
            };

            usuario.PasswordHash =
                _passwordHasher.HashPassword(
                    usuario,
                    solicitud.Password);

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return StatusCode(201, new
            {
                usuario.Id,
                usuario.Nombre,
                usuario.Correo,
                usuario.Rol
            });
        }

        // INICIAR SESION Y GENERAR TOKEN JWT
        [HttpPost("login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginUsuarioRequest solicitud)
        {
            if (solicitud == null ||
                string.IsNullOrWhiteSpace(solicitud.Correo) ||
                string.IsNullOrWhiteSpace(solicitud.Password))
            {
                return BadRequest(
                    "Correo y contraseña son obligatorios.");
            }

            string correo = solicitud.Correo
                .Trim()
                .ToLowerInvariant();

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Correo == correo);

            if (usuario == null || !usuario.Activo)
            {
                return Unauthorized(
                    "Correo o contraseña incorrectos.");
            }

            var resultado =
                _passwordHasher.VerifyHashedPassword(
                    usuario,
                    usuario.PasswordHash,
                    solicitud.Password);

            if (resultado == PasswordVerificationResult.Failed)
            {
                return Unauthorized(
                    "Correo o contraseña incorrectos.");
            }

            // OBTENER CONFIGURACION JWT
            string jwtKey = _configuration["Jwt:Key"]
                ?? throw new InvalidOperationException(
                    "No se encontro la clave JWT.");

            string jwtIssuer = _configuration["Jwt:Issuer"]
                ?? throw new InvalidOperationException(
                    "No se encontro el emisor JWT.");

            string jwtAudience = _configuration["Jwt:Audience"]
                ?? throw new InvalidOperationException(
                    "No se encontro la audiencia JWT.");

            // CREAR IDENTIDAD DEL USUARIO
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,
                    usuario.Id.ToString()),

                new Claim(ClaimTypes.Name,
                    usuario.Nombre),

                new Claim(ClaimTypes.Email,
                    usuario.Correo),

                new Claim(ClaimTypes.Role,
                    usuario.Rol)
            };

            // FIRMAR EL TOKEN
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtKey));

            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            // GENERAR TOKEN CON DURACION DE 1 HORA
            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            string tokenGenerado =
                new JwtSecurityTokenHandler()
                    .WriteToken(token);

            return Ok(new
            {
                Mensaje = "Inicio de sesion exitoso.",
                Token = tokenGenerado,
                ExpiraEnMinutos = 60,
                usuario.Id,
                usuario.Nombre,
                usuario.Correo,
                usuario.Rol
            });
        }
    }

    // DATOS PARA REGISTRAR USUARIOS
    public class RegistrarUsuarioRequest
    {
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    // DATOS PARA INICIAR SESION
    public class LoginUsuarioRequest
    {
        public string Correo { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}