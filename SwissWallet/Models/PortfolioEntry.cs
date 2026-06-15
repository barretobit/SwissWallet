namespace SwissWallet.Models;

public class PortfolioEntry
{
    public int Id { get; set; }
    public int PortfolioId { get; set; }
    public DateTime EntryDate { get; set; }
    public EntryType EntryType { get; set; }
    public decimal Amount { get; set; }
    public string? Notes { get; set; }
}
