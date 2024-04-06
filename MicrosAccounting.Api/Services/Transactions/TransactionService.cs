using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Services.Transactions;

public class TransactionService : ITransactionService
{
    private readonly IStorageBroker storageBroker;

    public TransactionService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    public async ValueTask<Transaction> AddTransactionAsync(Transaction transaction) =>
        await this.storageBroker.InsertTransactionAsync(transaction);

    public IQueryable<Transaction> RetrieveTransactionsAsync() =>
        this.storageBroker.SelectTransactions();

    public async ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction) =>
        await this.storageBroker.UpdateTransactionAsync(transaction);

    public ValueTask<Transaction> RemoveTransactionAsync(Transaction transaction) =>
        this.storageBroker.DeleteTransactionAsync(transaction);
}