namespace SwissWallet.Core.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string Username { get; set; } = null!;

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}