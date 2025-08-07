using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<UsuarioDto?> ObtenerUsuarioPorIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return _context.Usuarios
                .AsNoTracking()
                .Where(u => u.IdUsuario == id)
                .Select(MapearUsuarioDto)
                .SingleOrDefaultAsync(cancellationToken);
        }

        public Task<List<UsuarioDto>> ListarAsync(CancellationToken cancellationToken = default)
        {
            return _context.Usuarios
                .AsNoTracking()
                .Select(MapearUsuarioDto)
                .ToListAsync(cancellationToken);
        }

        public Task<UsuarioDto?> ObtenerUsuarioPorCorreoAsync(string correo, CancellationToken cancellationToken = default)
        {
            return _context.Usuarios
                .AsNoTracking()
                .Where(u => u.CorreoElectronico == correo)
                .Select(MapearUsuarioDto)
                .SingleOrDefaultAsync(cancellationToken);
        }

        private static UsuarioDto MapearUsuarioDto(Usuario u)
        {
            return new UsuarioDto
            {
                IdUsuario = u.IdUsuario,
                CorreoElectronico = u.CorreoElectronico,
                MetodoAutenticacion = u.MetodoAutenticacion,
                TipoAcceso = u.TipoAcceso,
                Estado = u.Estado,
                FechaRegistro = u.FechaRegistro
            };
        }
    }
}
