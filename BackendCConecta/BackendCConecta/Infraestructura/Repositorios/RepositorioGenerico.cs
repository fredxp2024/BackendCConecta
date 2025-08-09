using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using BackendCConecta.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace BackendCConecta.Infraestructura.Repositorios;

/// <summary>
/// Implementación genérica de operaciones comunes para repositorios.
/// </summary>
/// <typeparam name="T">Tipo de la entidad manejada.</typeparam>
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositorioGenerico(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<T?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object?[] { id }, cancellationToken);
        }

        public virtual async Task<IEnumerable<T>> ObtenerTodosAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public virtual async Task InsertarAsync(T entidad, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entidad, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task ActualizarAsync(T entidad, CancellationToken cancellationToken = default)
        {
            _dbSet.Update(entidad);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task EliminarAsync(T entidad, CancellationToken cancellationToken = default)
        {
            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicado, CancellationToken cancellationToken = default)
        {
            return await _dbSet.Where(predicado).ToListAsync(cancellationToken);
        }
    }
