using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendCConecta.Aplicacion.Modulos.Usuarios.DTOs;
using BackendCConecta.Aplicacion.Modulos.Usuarios.Interfaces;
using BackendCConecta.Dominio.Entidades.Usuarios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Servicios.Usuarios
{
    public class UsuarioQueryService : IUsuarioQueryService
    {
        private readonly AppDbContext _context;

        public UsuarioQueryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> ObtenerPorIdAsync(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == id);
        }

        public async Task<List<Usuario>> ListarAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<UsuarioDto?> ObtenerUsuarioPorIdAsync(int idUsuario)
        {
            return await _context.Usuarios
                .Where(u => u.IdUsuario == idUsuario)
                .Select(u => new UsuarioDto
                {
                    IdUsuario = u.IdUsuario,
                    CorreoElectronico = u.CorreoElectronico,
                    MetodoAutenticacion = u.MetodoAutenticacion,
                    TipoAcceso = u.TipoAcceso,
                    Estado = u.Estado,
                    FechaRegistro = u.FechaRegistro
                })
                .FirstOrDefaultAsync();
        }

        public async Task<UsuarioDto?> ObtenerUsuarioPorCorreoAsync(string correo)
        {
            return await _context.Usuarios
                .Where(u => u.CorreoElectronico == correo)
                .Select(u => new UsuarioDto
                {
                    IdUsuario = u.IdUsuario,
                    CorreoElectronico = u.CorreoElectronico,
                    MetodoAutenticacion = u.MetodoAutenticacion,
                    TipoAcceso = u.TipoAcceso,
                    Estado = u.Estado,
                    FechaRegistro = u.FechaRegistro
                })
                .FirstOrDefaultAsync();
        }
    }
}
