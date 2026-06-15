using Microsoft.EntityFrameworkCore;
using SwissWallet.Models;

namespace SwissWallet.Data;

public class SwissWalletDbContext(DbContextOptions<SwissWalletDbContext> options) : DbContext(options)
{
    public DbSet<Provider> Providers => Set<Provider>();
    public DbSet<Portfolio> Portfolios => Set<Portfolio>();
    public DbSet<PortfolioEntry> PortfolioEntries => Set<PortfolioEntry>();
    public DbSet<Liability> Liabilities => Set<Liability>();
    public DbSet<LiabilityEntry> LiabilityEntries => Set<LiabilityEntry>();
    public DbSet<ExchangeRate> ExchangeRates => Set<ExchangeRate>();
    public DbSet<AppSettings> AppSettings => Set<AppSettings>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.HasKey(e => e.CurrencyCode);
        });

        modelBuilder.Entity<AppSettings>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
    }
}
