using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Service.Services
{
    public class TransactionsService : ITransactionsService
    {
        public readonly ITransactionRepository TransactionRepository;
        public readonly ILogService LogService;

        public TransactionsService(ITransactionRepository transactionRepository, ILogService logService)
        {
            TransactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
            LogService = logService ?? throw new ArgumentNullException(nameof(logService));
        }
        public ContractResponse GetTransactionsByMerchant(Guid merchantId)
        {
            try
            {
                var transactions = TransactionRepository.GetTransactionsByMerchant(merchantId);
                return new ContractResponse().Success(transactions);
            }
            catch (Exception ex)
            {
                LogService.Error(ex, $"There was an error fetching transactions for the merchant {merchantId}");
                return new ContractResponse().InternalServerError("An internal error has occurred. Contact API Manager.");
            }

        }
    }
}
