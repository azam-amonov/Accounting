using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Transactions;
using Microsoft.EntityFrameworkCore;

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

    public IQueryable<Transaction> RetrieveTransactionByDateAsync(DateTimeOffset transactionDate)
    {
        var transactions = this.storageBroker.SelectAllTransactions();
        var maybeTransaction = transactions.Where(item =>
            item.CreatedAt == transactionDate);
        
        return maybeTransaction;
    }

    public async ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction) =>
        await this.storageBroker.UpdateTransactionAsync(transaction);

    public ValueTask<Transaction> RemoveTransactionByIdAsync(Guid transactionId) =>
        this.storageBroker.DeleteTransactionByIdAsync(transactionId);
}