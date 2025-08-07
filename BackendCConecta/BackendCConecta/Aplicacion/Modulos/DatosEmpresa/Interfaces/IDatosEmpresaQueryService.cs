using BackendCConecta.Aplicacion.Modulos.DatosEmpresa.DTOs;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresa.Interfaces;

public interface IDatosEmpresaQueryService
{
    Task<DatosEmpresaDto?> ObtenerPorIdAsync(int idDatosUsuario);
    Task<IEnumerable<DatosEmpresaDto>> ListarAsync();
}
