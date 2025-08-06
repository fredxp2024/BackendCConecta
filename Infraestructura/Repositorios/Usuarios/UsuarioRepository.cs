using Microsoft.EntityFrameworkCore;
using BackendCConecta.Infraestructura.Persistencia;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Dominio.Entidades.Usuarios;



namespace BackendCConecta.Infraestructura.Repositorios.Usuarios;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario?> ObtenerPorCorreoAsync(string correo)
    {
        return await _context.Usuarios
            .Include(u => u.DatosUsuario)
            .FirstOrDefaultAsync(u => u.CorreoElectronico == correo && u.Estado == "activo");
    }
}

