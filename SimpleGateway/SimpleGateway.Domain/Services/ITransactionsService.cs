using SimpleGateway.Domain.Contracts.Response;
using System;

namespace SimpleGateway.Domain.Services
{
    public interface ITransactionsService
    {
        ContractResponse GetTransactionsByMerchant(Guid merchantId);
    }
}