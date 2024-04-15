using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    public async ValueTask<Transaction> 
        InsertTransactionAsync(Transaction transaction) =>
        await this.InsertAsync(transaction);

    public IQueryable<Transaction> SelectAllTransactions() =>
        this.SelectAll<Transaction>();

    public async ValueTask<Transaction?> 
        SelectTransactionByIdAsync(Guid transactionId) =>
        await this.SelectAsync<Transaction>(transactionId);

    public async ValueTask<Transaction>
        UpdateTransactionAsync(Transaction transaction) =>
        await this.UpdateAsync(transaction);

    public async ValueTask<Transaction> 
        DeleteTransactionByIdAsync(Guid transactionId) 
    {
        var maybeTransaction = await SelectTransactionByIdAsync(transactionId);
        var deletedTransaction = await this.DeleteAsync(maybeTransaction);
        
        return deletedTransaction;
    }
}