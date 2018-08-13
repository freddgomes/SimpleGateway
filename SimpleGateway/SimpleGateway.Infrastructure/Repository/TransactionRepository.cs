using SimpleGateway.Domain.Configuration;
using SimpleGateway.Domain.Entities;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Infrastructure.Configuration.Context;

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

        private string ConnectionString()
        {
            return AppSettings.GetConfig("AppSettings:ConnectionString:SimpleGateway");
        }

    }
}
