using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Orchestration;

namespace MicrosAccounting.Api.Services.Orchestration;

public class TransactionResultService : ITransactionResultService
{
    public IQueryable<TransactionResult> RetrieveAllTransactionResult()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByAccounting(CategoryAccount category)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByName(IEnumerable<string> name)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByDate(DateOnly date)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultBetweenDate(DateOnly startDate, DateOnly endDate)
    {
        throw new NotImplementedException();
    }
}