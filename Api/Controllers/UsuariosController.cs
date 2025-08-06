using Microsoft.AspNetCore.Mvc;
using MediatR;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Consultas;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;

namespace BackendCConecta.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Registra un nuevo usuario en el sistema.
        /// </summary>
        /// <param name="command">Datos del usuario a registrar.</param>
        /// <returns>Usuario registrado.</returns>
        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] RegistrarUsuarioCommand command)
        {
            var resultado = await _mediator.Send(command);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = resultado.IdUsuario }, resultado);
        }

        /// <summary>
        /// Actualiza los datos de un usuario existente.
        /// </summary>
        /// <param name="id">ID del usuario a actualizar.</param>
        /// <param name="command">Datos actualizados del usuario.</param>
        /// <returns>204 No Content si se actualiza correctamente.</returns>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] ActualizarUsuarioCommand command)
        {
            if (id != command.IdUsuario)
                return BadRequest("El ID de la URL no coincide con el del cuerpo de la solicitud.");

            await _mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Elimina un usuario por su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar.</param>
        /// <returns>204 No Content si se elimina correctamente.</returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _mediator.Send(new EliminarUsuarioCommand(id));
            return NoContent();
        }

        /// <summary>
        /// Obtiene la lista de todos los usuarios registrados.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> Listar()
        {
            var usuarios = await _mediator.Send(new ListarUsuariosQuery());
            return Ok(usuarios);
        }

        /// <summary>
        /// Obtiene los detalles de un usuario por su ID.
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <returns>Usuario encontrado o 404 si no existe.</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UsuarioDto>> ObtenerPorId(int id)
        {
            var usuario = await _mediator.Send(new ObtenerUsuarioPorIdQuery(id));

            if (usuario is null)
                return NotFound();

            return Ok(usuario);
        }
    }
}
