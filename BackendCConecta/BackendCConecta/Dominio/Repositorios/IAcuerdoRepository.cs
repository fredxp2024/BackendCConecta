using BackendCConecta.Dominio.Entidades.Acuerdos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Dominio.Repositorios;

public interface IAcuerdoRepository
{
    Task<AcuerdosComercial?> ObtenerPorIdAsync(int id);
    Task<List<AcuerdosComercial>> ListarAsync();
    Task<List<AcuerdosComercial>> ObtenerPorUsuarioAsync(int idDatosUsuario);
    Task<int> CrearAsync(AcuerdosComercial entidad);
    Task<bool> ActualizarAsync(AcuerdosComercial entidad);
    Task<bool> EliminarAsync(int id);
}
