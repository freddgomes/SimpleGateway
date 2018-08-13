using SimpleGateway.Domain.Entities;

namespace SimpleGateway.Domain.Repository
{
    public interface ITransactionRepository
    {
        void SaveTransaction(Transaction transaction);
    }
}