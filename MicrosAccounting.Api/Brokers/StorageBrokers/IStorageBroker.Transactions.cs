using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<Transaction> InsertTransactionAsync(Transaction transaction);
    IQueryable<Transaction> SelectAllTransaction();
    ValueTask<Transaction> UpdateTransactionAsync(Transaction transaction);
}