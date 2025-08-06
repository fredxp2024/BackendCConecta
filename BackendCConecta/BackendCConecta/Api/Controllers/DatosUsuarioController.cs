
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios.Consultas;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // Requiere JWT por defecto
public class DatosUsuarioController : ControllerBase
{
    private readonly IMediator _mediator;

    public DatosUsuarioController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Listar todos los datos de usuarios
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new ListarDatosUsuarioQuery(), cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Obtener un dato de usuario por ID
    /// </summary>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new ObtenerDatosUsuarioPorIdQuery(id), cancellationToken);
        return result is null ? NotFound() : Ok(result);
    }

    /// <summary>
    /// Crear un nuevo dato de usuario
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CrearDatosUsuarioCommand command, CancellationToken cancellationToken)
    {
        var idCreado = await _mediator.Send(command, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = idCreado }, command);
    }

    /// <summary>
    /// Actualizar un dato de usuario existente
    /// </summary>
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] ActualizarDatosUsuarioCommand command, CancellationToken cancellationToken)
    {
        if (id != command.IdDatosUsuario)
            return BadRequest("El ID no coincide con el del cuerpo del mensaje.");

        var result = await _mediator.Send(command, cancellationToken);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// Eliminar un dato de usuario por ID
    /// </summary>
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new EliminarDatosUsuarioCommand(id), cancellationToken);
        return result ? NoContent() : NotFound();
    }
}
