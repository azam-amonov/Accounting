using System.Text.Json.Serialization;
using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Models.Transactions;

public class Transaction
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string? Comment { get; set; }
    public decimal Amount { get; set; }
    [JsonIgnore]
    public virtual Category Category { get; set; }
    [JsonIgnore]
    public virtual User User { get; set; }
}