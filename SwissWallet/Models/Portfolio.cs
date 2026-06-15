namespace SwissWallet.Models;

public class Portfolio
{
    public int Id { get; set; }
    public int ProviderId { get; set; }
    public string Name { get; set; } = string.Empty;
    public AssetType AssetType { get; set; }
    public string CurrencyCode { get; set; } = "CHF";
    public bool IsLiquid { get; set; }
    public string? Notes { get; set; }
}
