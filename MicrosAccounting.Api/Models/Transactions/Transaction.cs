namespace MicrosAccounting.Api.Models.Transactions;

public class Transaction
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string? Comment { get; set; }
    public decimal Amount { get; set; }
}