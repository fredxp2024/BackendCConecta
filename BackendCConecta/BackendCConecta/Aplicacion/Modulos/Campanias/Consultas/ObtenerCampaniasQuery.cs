using BackendCConecta.Aplicacion.Modulos.Campanias.DTOs;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.Campanias.Consultas;

/// <summary>
/// Query to retrieve all campaigns.
/// </summary>
public class ObtenerCampaniasQuery : IRequest<IReadOnlyList<CampaniaDTO>>
{
}

