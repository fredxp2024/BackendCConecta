using BackendCConecta.Dominio.Entidades.Acuerdos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendCConecta.Infraestructura.Repositorios.Acuerdos;

public class AcuerdoRepository
{
    public Task<AcuerdosComercial?> ObtenerPorIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<List<AcuerdosComercial>> ListarAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task<List<AcuerdosComercial>> ObtenerPorUsuarioAsync(int idDatosUsuario)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> CrearAsync(AcuerdosComercial entidad)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> ActualizarAsync(AcuerdosComercial entidad)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> EliminarAsync(int id)
    {
        throw new System.NotImplementedException();
    }
}
