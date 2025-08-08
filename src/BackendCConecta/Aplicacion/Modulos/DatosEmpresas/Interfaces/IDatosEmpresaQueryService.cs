using BackendCConecta.Aplicacion.Modulos.DatosEmpresas.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;

public interface IDatosEmpresaQueryService
{
    Task<DatosEmpresaDto?> ObtenerPorIdAsync(int idDatosUsuario);
    Task<IEnumerable<DatosEmpresaDto>> ListarAsync();
}
