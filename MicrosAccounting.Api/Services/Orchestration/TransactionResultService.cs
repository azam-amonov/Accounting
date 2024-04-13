using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Orchestration;
using MicrosAccounting.Api.Services.Foundations;
using MicrosAccounting.Api.Services.Foundations.Transactions;

namespace MicrosAccounting.Api.Services.Orchestration;

public class TransactionResultService : ITransactionResultService
{
    private readonly ITransactionService transactionService;
    private readonly ICategoryService categoryService;

    public TransactionResultService(ITransactionService transactionService, ICategoryService categoryService)
    {
        this.transactionService = transactionService;
        this.categoryService = categoryService;
    }

    public IQueryable<TransactionResult> RetrieveAllTransactionResult()
    {
        var maybeTransactionResult =
            transactionService.RetrieveAllTransactions()
                .Join(
                    categoryService.RetrieveAllCategories(),
                    transaction => transaction.CategoryId,
                    category => category.Id,
                    (transaction, category) => new TransactionResult
                    {
                        Transaction = transaction,
                        Category = category

                    });
        
        return maybeTransactionResult;
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByAccounting(CategoryAccount categoryAccount)
    {
        var transactionResult = categoryService.RetrieveAllCategories()
            .Where(category => category.Accounting == categoryAccount)
            .Join(transactionService.RetrieveAllTransactions(),
                category => category.Id,
                transaction => transaction.CategoryId,
                (category, transaction) => new TransactionResult
                {
                    Transaction = transaction,
                    Category = category
                });

        return transactionResult;
    }

    public IQueryable<TransactionResult> RetrieveTransactionResultByName(IEnumerable<string> names)
    {
        var enteredNames = names.Select(name => name.ToLower());
        var maybeTransactionsResult = transactionService.RetrieveAllTransactions()
            .Join(categoryService.RetrieveAllCategories()
                    .Where(category => enteredNames.Contains(category.Name.ToLower())),
                transaction => transaction.CategoryId,
                category => category.Id,
                (transaction, category) => new TransactionResult
                {
                    Transaction = transaction,
                    Category = category
                });

        return maybeTransactionsResult;
    }
    

    public IQueryable<TransactionResult> RetrieveTransactionResultByDate(DateTime date)
    {
        var filteredTransactions = transactionService.RetrieveAllTransactions()
                .Where(transaction => transaction.CreatedAt.Date == date.Date);

        var transactionResult = categoryService.RetrieveAllCategories()
            .Join(filteredTransactions,
                category => category.Id,
                transaction => transaction.CategoryId,
                (category, transaction) => new TransactionResult
                {
                    Transaction = transaction,
                    Category = category,
                });

        return transactionResult;
    }

    public IQueryable<TransactionResult> 
        RetrieveTransactionResultBetweenDate(DateTime startDate, DateTime endDate)
    {
        var filteredTransactions = transactionService
            .RetrieveAllTransactions()
            .Where(transaction => transaction.CreatedAt.Date >= startDate 
                                  && transaction.CreatedAt.Date <= endDate);

        var transactionResult = categoryService.RetrieveAllCategories()
            .Join(filteredTransactions,
                category => category.Id,
                transaction => transaction.CategoryId,
                (category, transaction) => new TransactionResult
                {
                    Transaction = transaction,
                    Category = category,
                });

        return transactionResult;
    }
}