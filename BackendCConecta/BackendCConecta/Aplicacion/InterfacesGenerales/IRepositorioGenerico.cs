using System.Linq.Expressions;

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
    Task<T?> ObtenerPorIdAsync(int id);

    /// <summary>
    /// Obtiene todas las entidades del tipo especificado.
    /// </summary>
    Task<IEnumerable<T>> ObtenerTodosAsync();

    /// <summary>
    /// Inserta una nueva entidad en el contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a insertar.</param>
    Task InsertarAsync(T entidad);

    /// <summary>
    /// Actualiza una entidad existente en el contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a actualizar.</param>
    Task ActualizarAsync(T entidad);

    /// <summary>
    /// Elimina una entidad del contexto de datos.
    /// </summary>
    /// <param name="entidad">Entidad a eliminar.</param>
    Task EliminarAsync(T entidad);

    /// <summary>
    /// Permite realizar consultas personalizadas sobre la entidad.
    /// </summary>
    /// <param name="predicado">Expresión con la condición de filtro.</param>
    Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicado);
}
