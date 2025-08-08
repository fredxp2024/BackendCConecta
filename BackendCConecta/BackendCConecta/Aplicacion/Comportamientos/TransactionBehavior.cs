using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using BackendCConecta.Aplicacion.InterfacesGenerales;

namespace BackendCConecta.Aplicacion.Comportamientos
{
    /// <summary>
    /// Comportamiento de pipeline que envuelve comandos en una transacción.
    /// </summary>
    public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly ITransactionService _transactionService;
        private readonly ILogger<TransactionBehavior<TRequest, TResponse>> _logger;

        public TransactionBehavior(ITransactionService transactionService, ILogger<TransactionBehavior<TRequest, TResponse>> logger)
        {
            _transactionService = transactionService;
            _logger = logger;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            var isCommand = requestName.EndsWith("Command", StringComparison.InvariantCulture);

            if (!isCommand)
            {
                return next();
            }

            using (_logger.BeginScope(new Dictionary<string, object> { ["RequestName"] = requestName }))
            {
                return _transactionService.ExecuteAsync(async () =>
                {
                    _logger.LogInformation("Starting transaction for {RequestName}", requestName);
                    var response = await next();
                    _logger.LogInformation("Completed transaction for {RequestName}", requestName);
                    return response;
                }, cancellationToken);
            }
        }
    }
}

