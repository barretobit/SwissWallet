namespace SwissWallet.Core.Domain
{
    public class Transaction
    {
        public int Id { get; set; }

        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; } = null!;

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; } = null!;

        public string? Description { get; set; }
    }
}