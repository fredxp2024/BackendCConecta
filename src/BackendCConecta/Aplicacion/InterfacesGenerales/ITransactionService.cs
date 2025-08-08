using System.Threading;
using System.Threading.Tasks;

namespace BackendCConecta.Aplicacion.InterfacesGenerales
{
    /// <summary>
    /// Abstrae la creación y finalización de <see cref="System.Transactions.TransactionScope"/>.
    /// </summary>
    public interface ITransactionService
    {
        /// <summary>
        /// Ejecuta una operación dentro de una transacción y devuelve un resultado.
        /// </summary>
        /// <typeparam name="T">Tipo del resultado.</typeparam>
        /// <param name="action">Función a ejecutar.</param>
        /// <param name="cancellationToken">Token de cancelación.</param>
        Task<T> ExecuteAsync<T>(Func<Task<T>> action, CancellationToken cancellationToken = default);

        /// <summary>
        /// Ejecuta una operación dentro de una transacción.
        /// </summary>
        /// <param name="action">Función a ejecutar.</param>
        /// <param name="cancellationToken">Token de cancelación.</param>
        Task ExecuteAsync(Func<Task> action, CancellationToken cancellationToken = default);
    }
}

