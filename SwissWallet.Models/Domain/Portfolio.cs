namespace SwissWallet.Models.Domain
{
    public class Portfolio
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; } = null!;

        public string Platform { get; set; } = null!;

        public User User { get; set; } = null!;

        public ICollection<PortfolioValuation> Valuations { get; set; } = new List<PortfolioValuation>();

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}