using System;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using BackendCConecta.Aplicacion.InterfacesGenerales;
using Microsoft.Extensions.Logging;

namespace BackendCConecta.Infraestructura.Servicios
{
    /// <summary>
    /// Implementación basada en <see cref="TransactionScope"/> para manejar transacciones.
    /// </summary>
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> _logger;

        public TransactionService(ILogger<TransactionService> logger)
        {
            _logger = logger;
        }

        public async Task<T> ExecuteAsync<T>(Func<Task<T>> action, CancellationToken cancellationToken = default)
        {
            using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                var result = await action();
                scope.Complete();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Transaction failed");
                throw;
            }
        }

        public async Task ExecuteAsync(Func<Task> action, CancellationToken cancellationToken = default)
        {
            using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                await action();
                scope.Complete();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Transaction failed");
                throw;
            }
        }
    }
}

