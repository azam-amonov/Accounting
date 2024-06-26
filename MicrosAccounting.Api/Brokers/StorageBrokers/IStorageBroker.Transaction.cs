using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<Transaction> InsertTransactionAsync(Transaction transaction);
    IQueryable<Transaction> SelectAllTransactions();
    ValueTask<Transaction?> SelectTransactionByIdAsync(Guid transactionId);
    ValueTask<Transaction> UpdateTransactionAsync(Transaction transaction);
    ValueTask<Transaction> DeleteTransactionByIdAsync(Guid transactionId);
}