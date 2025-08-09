using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.InterfacesGenerales;

/// <summary>
/// Define operaciones básicas para un repositorio genérico de entidades.
/// </summary>
/// <typeparam name="T">Tipo de la entidad manejada por el repositorio.</typeparam>
public interface IRepositorioGenerico<T> where T : class
{
    /// <summary>
    /// Obtiene una entidad por su identificador primario.
    /// </summary>
    /// <param name="id">Identificador de la entidad.</param>
    Task<T?> ObtenerPorIdAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Obtiene todas las entidades del tipo especificado.
    /// </summary>
    Task<IEnumerable<T>> ObtenerTodosAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Inserta una nueva entidad en el contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a insertar.</param>
    Task InsertarAsync(T entidad, CancellationToken cancellationToken = default);

    /// <summary>
    /// Actualiza una entidad existente en el contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a actualizar.</param>
    Task ActualizarAsync(T entidad, CancellationToken cancellationToken = default);

    /// <summary>
    /// Elimina una entidad del contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a eliminar.</param>
    Task EliminarAsync(T entidad, CancellationToken cancellationToken = default);

    /// <summary>
    /// Permite realizar consultas personalizadas sobre la entidad.
    /// </summary>
    /// <param name="predicado">Expresión con la condición de filtro.</param>
    Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicado, CancellationToken cancellationToken = default);
}
