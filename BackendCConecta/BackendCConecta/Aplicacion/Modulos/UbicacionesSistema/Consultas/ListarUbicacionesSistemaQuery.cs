using BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.DTOs;
using MediatR;

namespace BackendCConecta.Aplicacion.Modulos.UbicacionesSistema.Consultas;

public sealed record ListarUbicacionesSistemaQuery() : IRequest<List<UbicacionSistemaDto>>;

