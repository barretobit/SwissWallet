namespace SwissWallet.Models;

public class Liability
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CurrencyCode { get; set; } = "CHF";
    public string? Notes { get; set; }
}
