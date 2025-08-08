using BackendCConecta.Dominio.Entidades.Acuerdos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.Modulos.Acuerdos.Interfaces;

public interface IAcuerdoQueryService
{
    Task<List<AcuerdosComercial>> ListarAsync();
    Task<AcuerdosComercial?> ObtenerPorIdAsync(int id);
    Task<List<AcuerdosComercial>> ObtenerPorUsuarioAsync(int idDatosUsuario);
}
