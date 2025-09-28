namespace SwissWallet.Core.Domain
{
    public class Account
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Bank { get; set; } = null!;

        public string Currency { get; set; } = "CHF";

        public decimal CurrentBalance { get; set; }

        // public ICollection<AccountBalanceRecord> BalanceHistory { get; set; }
    }
}