using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Services.Foundations.Transactions;

public class TransactionService : ITransactionService
{
    private readonly IStorageBroker storageBroker;

    public TransactionService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    public async ValueTask<Transaction> AddTransactionAsync(Transaction transaction) =>
        await this.storageBroker.InsertTransactionAsync(transaction);

    public IQueryable<Transaction> RetrieveAllTransactions() =>
        this.storageBroker.SelectAllTransactions();

    public async ValueTask<Transaction?> RetrieveTransactionByIdAsync(Guid transactionId) =>
        await this.storageBroker.SelectTransactionByIdAsync(transactionId);

    public IQueryable<Transaction> RetrieveTransactionByDateAsync(DateTime transactionDate)
    {
        var transactions = this.storageBroker.SelectAllTransactions();
        var maybeTransactions = transactions.Where(item =>
            item.CreatedAt.Date == transactionDate.Date);
        
        return maybeTransactions;
    }

    public IQueryable<Transaction> RetrieveTransactionBetweenDateTime(DateTime startDate, DateTime endDate)
    {
        var transactions = this.storageBroker.SelectAllTransactions();
        var maybeTransactions = transactions.Where(item =>
            item.CreatedAt.Date >= startDate && item.CreatedAt.Date <= endDate)
            .OrderBy(item => item.CreatedAt);
        
        return maybeTransactions;
    }

    public IQueryable<Transaction> RetrieveTransactionByCategoryType(CategoryAccount accountingType)
    {
        var transactions = this.storageBroker.SelectAllTransactions()
            .Where(item => item.Category.Accounting == accountingType);

        return transactions;
    }

    public IQueryable<Transaction> RetrieveTransactionByCategoryName(IEnumerable<string> categoryName)
    {
        var transactions = this.storageBroker.SelectAllTransactions();
        var selectNames = categoryName.Select(time => time.ToLower());
        var maybeTransactions = transactions.Where(item => 
            selectNames.Contains(item.Category.Name.ToLower()));

        return maybeTransactions;
    }

    public async ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction) =>
        await this.storageBroker.UpdateTransactionAsync(transaction);

    public ValueTask<Transaction> RemoveTransactionByIdAsync(Guid transactionId) =>
        this.storageBroker.DeleteTransactionByIdAsync(transactionId);
}