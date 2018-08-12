using Microsoft.EntityFrameworkCore;
using Transaction = SimpleGateway.Domain.Entities.Transaction;

namespace SimpleGateway.Infrastructure.Configuration.Context
{
    class TransactionDbContext : DbContext
    {
        private readonly string ConnectionString;
        public TransactionDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasKey(t => t.Id);
        }
    }
}
