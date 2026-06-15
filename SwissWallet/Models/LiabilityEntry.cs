namespace SwissWallet.Models;

public class LiabilityEntry
{
    public int Id { get; set; }
    public int LiabilityId { get; set; }
    public DateTime EntryDate { get; set; }
    public decimal Amount { get; set; }
    public string? Notes { get; set; }
}
