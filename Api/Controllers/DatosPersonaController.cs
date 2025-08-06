using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosPersona.DTOs;

namespace BackendCConecta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Puedes personalizar los roles si lo deseas
    public class DatosPersonaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DatosPersonaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Listar todas las personas registradas.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatosPersonaDto>>> Listar()
        {
            var resultado = await _mediator.Send(new ListarDatosPersonaQuery());
            return Ok(resultado);
        }

        /// <summary>
        /// Obtener datos de una persona por ID de usuario.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<DatosPersonaDto>> ObtenerPorId(int id)
        {
            var resultado = await _mediator.Send(new ObtenerDatosPersonaPorIdQuery(id));
            if (resultado is null) return NotFound();
            return Ok(resultado);
        }

        /// <summary>
        /// Crear nueva persona.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<int>> Crear([FromBody] CrearDatosPersonaDto dto)
        {
            var id = await _mediator.Send(new CrearDatosPersonaCommand(dto));
            return CreatedAtAction(nameof(ObtenerPorId), new { id }, null);
        }

        /// <summary>
        /// Actualizar datos de una persona.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] ActualizarDatosPersonaDto dto)
        {
            await _mediator.Send(new ActualizarDatosPersonaCommand(id, dto));
            return NoContent();
        }

        /// <summary>
        /// Eliminar datos de una persona.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _mediator.Send(new EliminarDatosPersonaCommand(id));
            return NoContent();
        }
    }
}
