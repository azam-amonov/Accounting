using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Orchestration;

namespace MicrosAccounting.Api.Services.Orchestration;

public interface ITransactionResultService
{
    IQueryable<TransactionResult> RetrieveAllTransactionResult();
    IQueryable<TransactionResult> RetrieveTransactionResultByAccounting(CategoryAccount category);
    IQueryable<TransactionResult> RetrieveTransactionResultByName(IEnumerable<string> name);
    IQueryable<TransactionResult> RetrieveTransactionResultByDate(DateTime date);
    IQueryable<TransactionResult> RetrieveTransactionResultBetweenDate(DateTime startDate, DateTime endDate);
}