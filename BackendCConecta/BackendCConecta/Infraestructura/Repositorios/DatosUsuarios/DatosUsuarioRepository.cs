using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.DatosUsuarios;
using BackendCConecta.Infraestructura.Persistencia;
using BackendCConecta.Dominio.Entidades.UsuariosDatos;


namespace BackendCConecta.Infraestructura.Repositorios.DatosUsuarios;

public class DatosUsuarioRepository : IDatosUsuarioRepository
{
    private readonly AppDbContext _context;

    public DatosUsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DatosUsuario>> ObtenerTodosAsync()
    {
        return await _context.DatosUsuarios.ToListAsync();
    }

    public async Task<DatosUsuario?> ObtenerPorIdAsync(int id)
    {
        return await _context.DatosUsuarios.FindAsync(id);
    }

    public async Task<DatosUsuario?> ObtenerPorUsuarioIdAsync(int idUsuario)
    {
        return await _context.DatosUsuarios
            .FirstOrDefaultAsync(d => d.IdUsuario == idUsuario);
    }

    public async Task RegistrarAsync(DatosUsuario datos)
    {
        await _context.DatosUsuarios.AddAsync(datos);
        await _context.SaveChangesAsync();
    }

    public async Task<int> RegistrarYRetornarIdAsync(DatosUsuario datos)
    {
        await _context.DatosUsuarios.AddAsync(datos);
        await _context.SaveChangesAsync();
        return datos.IdDatosUsuario;
    }

    public void Actualizar(DatosUsuario datos)
    {
        _context.DatosUsuarios.Update(datos);
    }

    public void Eliminar(DatosUsuario datos)
    {
        _context.DatosUsuarios.Remove(datos);
    }
}
