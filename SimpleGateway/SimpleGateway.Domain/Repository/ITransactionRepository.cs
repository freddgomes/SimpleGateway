using SimpleGateway.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SimpleGateway.Domain.Repository
{
    public interface ITransactionRepository
    {
        void SaveTransaction(Transaction transaction);
        List<Transaction> GetTransactionsByMerchant(Guid merchantId);
    }
}