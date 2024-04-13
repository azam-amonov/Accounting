using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Models.Orchestration;

public class TransactionResult
{
    public Transaction? Transaction { get; set; }
    public Category? Category { get; set; }
}