using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Service.Services
{
    public class TransactionsService : ITransactionsService
    {
        public readonly ITransactionRepository TransactionRepository;

        public TransactionsService(ITransactionRepository transactionRepository)
        {
            TransactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
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
                return new ContractResponse().InternalServerError("An internal error has occurred. Contact API Manager.");
            }

        }
    }
}
