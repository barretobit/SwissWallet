using Microsoft.EntityFrameworkCore;
using SwissWallet.Core.Domain;

namespace SwissWallet.Data
{
    public class SwissWalletDbContext : DbContext
    {
        public SwissWalletDbContext(DbContextOptions<SwissWalletDbContext> options)
            : base(options) { }

        public DbSet<User> Users => Set<User>();

        public DbSet<Account> Accounts => Set<Account>();

        public DbSet<Portfolio> Portfolios => Set<Portfolio>();

        public DbSet<Transaction> Transactions => Set<Transaction>();

        public DbSet<PortfolioValuation> Valuations => Set<PortfolioValuation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent config later if needed
        }
    }
}