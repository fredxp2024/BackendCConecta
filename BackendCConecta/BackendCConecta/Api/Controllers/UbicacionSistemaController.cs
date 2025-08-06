using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Comandos;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Handlers;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.Consultas;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.DTOs;
using System.Threading.Tasks;

namespace BackendCConecta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Aplica autenticación por JWT, puedes usar [Authorize(Roles = "Administrador")] si deseas limitar por rol
    public class UbicacionSistemaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UbicacionSistemaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Crear una nueva ubicación
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] CrearUbicacionSistemaCommand comando)
        {
            var resultado = await _mediator.Send(comando);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = resultado.IdUbicacion }, resultado);
        }

        /// <summary>
        /// Obtener ubicación por ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var resultado = await _mediator.Send(new ObtenerUbicacionSistemaPorIdQuery(id));
            if (resultado == null)
                return NotFound();
            return Ok(resultado);
        }

        /// <summary>
        /// Listar todas las ubicaciones
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var resultado = await _mediator.Send(new ListarUbicacionesSistemaQuery());
            return Ok(resultado);
        }

        /// <summary>
        /// Actualizar una ubicación existente
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] ActualizarUbicacionSistemaCommand comando)
        {
            if (id != comando.IdUbicacion)
                return BadRequest("El ID de la URL no coincide con el del cuerpo de la solicitud.");

            var resultado = await _mediator.Send(comando);
            return Ok(resultado);
        }

        /// <summary>
        /// Eliminar una ubicación
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _mediator.Send(new EliminarUbicacionSistemaCommand(id));
            return NoContent();
        }
    }
}
