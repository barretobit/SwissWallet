namespace SwissWallet.Models.Domain
{
    public class Portfolio
    {
        public int Id { get; set; }

        public required int UserId { get; set; }

        public required string Name { get; set; }

        public required string Currency { get; set; }

        public User User { get; set; } = null!;

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<PortfolioValuation> Valuations { get; set; } = new List<PortfolioValuation>();
    }
}