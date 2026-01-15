namespace SwissWallet.Models.Domain
{
    public class Account
    {
        public int Id { get; set; }

        public required int UserId { get; set; }

        public required string Name { get; set; }

        public required string Currency { get; set; }
        
        public string Platform { get; set; } = null!;

        public string Bank { get; set; } = null!;

        public decimal CurrentBalance { get; set; }

        public DateTime LastUpdate { get; set; }

        public User User { get; set; } = null!;

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}