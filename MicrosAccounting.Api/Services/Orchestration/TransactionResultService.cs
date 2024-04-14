using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Orchestration;

namespace MicrosAccounting.Api.Services.Orchestration;

public class TransactionResultService : ITransactionResultService
{
    private readonly IStorageBroker storageBroker;

    public TransactionResultService(
        IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    public IQueryable<TransactionResult> RetrieveAllTransactionResult()
    {
        var transactions = storageBroker.SelectAllTransactions()
            .Select(transaction => new TransactionResult
            {
                Transaction = transaction,
                Category = transaction.Category
            });

        return transactions;
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByAccounting(CategoryAccount categoryAccount)
    {
        var transactionResult = storageBroker.SelectAllTransactions()
            .Where(transaction => transaction.Category.Accounting == categoryAccount)
            .Select(transaction => new TransactionResult
            {
                Transaction = transaction,
                Category = transaction.Category
            });

        return transactionResult;
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByDate(DateTime date)
    {
        var transactionResult = storageBroker.SelectAllTransactions()
            .Where(transaction => transaction.CreatedAt.Date == date.Date)
            .Select(transaction => new TransactionResult
            {
                Transaction = transaction,
                Category = transaction.Category
            });

        return transactionResult;
    }
    public IQueryable<TransactionResult> RetrieveTransactionResultByName(IEnumerable<string> names)
    {
        var enteredNames = names.Select(name => name.ToLower());
        
        var maybeTransactionsResult = storageBroker.SelectAllTransactions()
                .Where(transaction => enteredNames.Contains(transaction.Category!.Name.ToLower()))
                .Select(transaction => new TransactionResult
                {
                    Transaction = transaction,
                    Category = transaction.Category
                });

        return maybeTransactionsResult;
    }
    
    public IQueryable<TransactionResult> 
        RetrieveTransactionResultBetweenDate(DateTime startDate, DateTime endDate)
    {
        var transactionResult = storageBroker.SelectAllTransactions()
            .Where(transaction => transaction.CreatedAt.Date >= startDate 
                                  && transaction.CreatedAt.Date <= endDate)
            .Select(transaction => new TransactionResult
            {
                Transaction = transaction,
                Category = transaction.Category
            });

        return transactionResult;
    }
}