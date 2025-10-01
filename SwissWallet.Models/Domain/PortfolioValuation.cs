namespace SwissWallet.Models.Domain
{
    public class PortfolioValuation
    {
        public int Id { get; set; }

        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; } = null!;

        public DateTime ValuationDate { get; set; }

        public decimal TotalValue { get; set; }

        public string? Notes { get; set; }
    }
}