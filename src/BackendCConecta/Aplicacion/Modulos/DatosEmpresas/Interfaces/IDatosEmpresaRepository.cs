using BackendCConecta.Dominio.Entidades.Empresas;

namespace BackendCConecta.Aplicacion.Modulos.DatosEmpresas.Interfaces;

public interface IDatosEmpresaRepository
{
    Task CrearAsync(DatosEmpresa entidad);
    Task ActualizarAsync(DatosEmpresa entidad);
    Task EliminarAsync(int idDatosUsuario);
    Task<DatosEmpresa?> ObtenerPorIdAsync(int idDatosUsuario);
}
