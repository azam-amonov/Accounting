using System.Text.Json.Serialization;
using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Models.Users;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    [JsonIgnore]
    public virtual ICollection<Transaction>? Transactions { get; set; } 
}