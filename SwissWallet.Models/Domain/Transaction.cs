namespace SwissWallet.Models.Domain
{
    public class Transaction
    {
        public int Id { get; set; }

        public required int AccountId { get; set; }

        public required DateTime Date { get; set; }

        public required decimal Amount { get; set; }

        public required string Currency { get; set; }

        public required bool IsCredit { get; set; }

        public string? Description { get; set; }

        public Account Account { get; set; } = null!;
    }
}