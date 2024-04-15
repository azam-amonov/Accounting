using System.Text.Json.Serialization;
using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Models.Categories;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Accounting Accounting { get; set; }
    [JsonIgnore]
    public virtual ICollection<Transaction>? Transactions { get; set; }
}