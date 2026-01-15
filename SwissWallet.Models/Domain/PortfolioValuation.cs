namespace SwissWallet.Models.Domain
{
    public class PortfolioValuation
    {
        public int Id { get; set; }

        public required int PortfolioId { get; set; }

        public required DateTime ValuationDate { get; set; }

        public required decimal TotalValue { get; set; }

        public string? Notes { get; set; }
    }
}