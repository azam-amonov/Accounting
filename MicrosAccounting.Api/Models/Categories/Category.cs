using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Models.Categories;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Transaction>? Transactions { get; set; }
}