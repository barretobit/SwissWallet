namespace SwissWallet.Models;

public class AppSettings
{
    public int Id { get; set; }
    public string BaseCurrency { get; set; } = "CHF";
    public int BackupRetentionCount { get; set; } = 10;
}
