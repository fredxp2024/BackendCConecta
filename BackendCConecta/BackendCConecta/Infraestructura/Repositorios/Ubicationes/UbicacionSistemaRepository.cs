using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.UbicacionSistema;
using BackendCConecta.Aplicacion.Modulos.UbicacionSistema.DTOs;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicationes
{
    public class UbicacionSistemaRepository : IUbicacionesSistemaRepository
    {
        private readonly AppDbContext _context;

        public UbicacionSistemaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UbicacionSistema?> ObtenerPorIdAsync(int id)
        {
            return await _context.UbicacionSistema.FindAsync(id);
        }

        public async Task<IEnumerable<UbicacionSistema>> ListarAsync()
        {
            return await _context.UbicacionSistema.ToListAsync();
        }

        public async Task InsertarAsync(UbicacionSistema entidad)
        {
            await _context.UbicacionSistema.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(UbicacionSistema entidad)
        {
            _context.UbicacionSistema.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(UbicacionSistema entidad)
        {
            _context.UbicacionSistema.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
