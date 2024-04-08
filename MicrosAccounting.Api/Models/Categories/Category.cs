using MicrosAccounting.Api.Models.Transactions;
using Newtonsoft.Json;

namespace MicrosAccounting.Api.Models.Categories;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CategoryAccount Accounting { get; set; }
    [JsonIgnore]
    public virtual ICollection<Transaction>? Transactions { get; set; }
}