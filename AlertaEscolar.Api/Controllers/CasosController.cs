using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlertaEscolar.Api.Data;
using AlertaEscolar.Shared.Models;
using Microsoft.AspNetCore.Authorization;

namespace AlertaEscolar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CasosController : ControllerBase
    {
        private readonly AlertaEscolarPostgreSqlDbContext _context;

        public CasosController(
            AlertaEscolarPostgreSqlDbContext context)
        {
            _context = context;
        }

        // CONSULTAR TODOS LOS CASOS
        [HttpGet]
        public async Task<ActionResult<List<Caso>>> ObtenerCasos()
        {
            var casos = await _context.Casos.ToListAsync();

            return Ok(casos);
        }

        // CONSULTAR UN CASO POR ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Caso>> ObtenerCaso(int id)
        {
            var caso = await _context.Casos.FindAsync(id);

            if (caso == null)
            {
                return NotFound("Caso no encontrado.");
            }

            return Ok(caso);
        }

        // REGISTRAR UN NUEVO CASO
        [HttpPost]
        public async Task<ActionResult<Caso>> RegistrarCaso(
            Caso nuevoCaso)
        {
            if (string.IsNullOrWhiteSpace(nuevoCaso.Titulo) ||
                string.IsNullOrWhiteSpace(nuevoCaso.Descripcion))
            {
                return BadRequest(
                    "El título y la descripción son obligatorios.");
            }

            nuevoCaso.Id = 0;
            nuevoCaso.FechaRegistro = DateTime.UtcNow;
            nuevoCaso.Estado = "Pendiente";

            _context.Casos.Add(nuevoCaso);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(ObtenerCaso),
                new { id = nuevoCaso.Id },
                nuevoCaso);
        }

        // ACTUALIZAR EL ESTADO DE UN CASO
        [HttpPut("{id}/estado")]
        public async Task<IActionResult> ActualizarEstado(
            int id,
            [FromBody] ActualizarEstadoRequest solicitud)
        {
            var caso = await _context.Casos.FindAsync(id);

            if (caso == null)
            {
                return NotFound("Caso no encontrado.");
            }

            string[] estadosPermitidos =
            {
                "Pendiente",
                "En seguimiento",
                "Cerrado"
            };

            if (solicitud == null ||
                string.IsNullOrWhiteSpace(solicitud.Estado) ||
                !estadosPermitidos.Contains(solicitud.Estado))
            {
                return BadRequest(
                    "Estado no válido. Utilice Pendiente, En seguimiento o Cerrado.");
            }

            string estadoAnterior = caso.Estado;

            caso.Estado = solicitud.Estado;

            // GUARDAR EL CAMBIO EN EL HISTORIAL
            var historial = new HistorialCaso
            {
                CasoId = caso.Id,
                UsuarioId = caso.UsuarioResponsableId,
                Fecha = DateTime.UtcNow,
                DescripcionAccion =
                    $"Cambio de estado: {estadoAnterior} a {solicitud.Estado}",
                Estado = solicitud.Estado
            };

            _context.HistorialCasos.Add(historial);

            await _context.SaveChangesAsync();

            return Ok(caso);
        }

        // CONSULTAR EL HISTORIAL DE UN CASO
        [HttpGet("{id}/historial")]
        public async Task<ActionResult<List<HistorialCaso>>>
            ObtenerHistorial(int id)
        {
            var caso = await _context.Casos.FindAsync(id);

            if (caso == null)
            {
                return NotFound("Caso no encontrado.");
            }

            var historial = await _context.HistorialCasos
                .Where(h => h.CasoId == id)
                .OrderBy(h => h.Fecha)
                .ToListAsync();

            return Ok(historial);
        }

        // CONSULTAR EL HISTORIAL GENERAL DE TODOS LOS CASOS
        [HttpGet("historial")]
        public async Task<ActionResult<List<HistorialCaso>>>
            ObtenerHistorialGeneral()
        {
            var historial = await _context.HistorialCasos
                .AsNoTracking()
                .OrderByDescending(h => h.Fecha)
                .ToListAsync();

            return Ok(historial);
        }

        // MODELO PARA ACTUALIZAR ESTADOS
        public class ActualizarEstadoRequest
        {
            public string Estado { get; set; } = string.Empty;
        }
    }
}