namespace SwissWallet.Models.Domain
{
    public class User
    {
        public int Id { get; set; }

        public required string Email { get; set; } 

        public required string Username { get; set; } 

        public required string Password { get; set; } 

        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}