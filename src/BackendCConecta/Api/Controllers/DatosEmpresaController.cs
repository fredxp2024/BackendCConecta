using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Comandos;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Consultas;
using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class DatosEmpresaController : ControllerBase
{
    private readonly IMediator _mediator;

    public DatosEmpresaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DatosEmpresaDto>>> Listar()
    {
        var resultado = await _mediator.Send(new ListarDatosEmpresaQuery());
        return Ok(resultado);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DatosEmpresaDto>> ObtenerPorId(int id)
    {
        var resultado = await _mediator.Send(new ObtenerDatosEmpresaPorIdQuery(id));
        if (resultado is null) return NotFound();
        return Ok(resultado);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Crear([FromBody] CrearDatosEmpresaDto dto)
    {
        var id = await _mediator.Send(new CrearDatosEmpresaCommand(dto));
        return CreatedAtAction(nameof(ObtenerPorId), new { id }, null);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Actualizar(int id, [FromBody] ActualizarDatosEmpresaDto dto)
    {
        await _mediator.Send(new ActualizarDatosEmpresaCommand(id, dto));
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Eliminar(int id)
    {
        await _mediator.Send(new EliminarDatosEmpresaCommand(id));
        return NoContent();
    }
}
