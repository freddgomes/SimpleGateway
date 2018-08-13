using SimpleGateway.Domain.Configuration;
using SimpleGateway.Domain.Entities;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Infrastructure.Configuration.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleGateway.Infrastructure.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private TransactionDbContext _db;
        private readonly IAppSettings AppSettings;

        public TransactionRepository(IAppSettings appSettings)
        {
            AppSettings = appSettings;
        }

        public void SaveTransaction(Transaction transaction)
        {
            _db = new TransactionDbContext(ConnectionString());

            _db.Transactions.Add(transaction);
            _db.SaveChanges();
        }

        public List<Transaction> GetTransactionsByMerchant(Guid merchantId)
        {
            _db = new TransactionDbContext(ConnectionString());
            return _db.Transactions.Where(x => x.MerchantId == merchantId).ToList();
        }

        private string ConnectionString()
        {
            return AppSettings.GetConfig("AppSettings:ConnectionString:SimpleGateway");
        }

    }
}
