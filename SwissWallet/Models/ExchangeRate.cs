namespace SwissWallet.Models;

public class ExchangeRate
{
    public string CurrencyCode { get; set; } = string.Empty;
    public decimal ChfRate { get; set; }
    public DateTime LastUpdated { get; set; }
}
