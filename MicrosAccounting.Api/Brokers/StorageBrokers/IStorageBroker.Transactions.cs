using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<Transaction> InsertTransactionAsync(Transaction transaction);
    IQueryable<Transaction> SelectTransactions();
    ValueTask<Transaction> UpdateTransactionAsync(Transaction transaction);
    ValueTask<Transaction> DeleteTransactionAsync(Transaction transaction);
}