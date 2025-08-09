using Microsoft.EntityFrameworkCore;
using BackendCConecta.Dominio.Entidades.Ubicaciones;
using BackendCConecta.Dominio.Repositorios;
using BackendCConecta.Infraestructura.Persistencia;

namespace BackendCConecta.Infraestructura.Repositorios.Ubicaciones
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
            return await _context.UbicacionesSistema.FindAsync(id);
        }

        public async Task<IEnumerable<UbicacionSistema>> ListarAsync()
        {
            return await _context.UbicacionesSistema.ToListAsync();
        }

        public async Task InsertarAsync(UbicacionSistema entidad)
        {
            await _context.UbicacionesSistema.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(UbicacionSistema entidad)
        {
            _context.UbicacionesSistema.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(UbicacionSistema entidad)
        {
            _context.UbicacionesSistema.Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
}
