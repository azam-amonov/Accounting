using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Services.Transactions;

public interface ITransactionService
{
    ValueTask<Transaction> AddTransactionAsync(Transaction transaction);
    IQueryable<Transaction> RetrieveAllTransactions();
    ValueTask<Transaction> RetrieveTransactionByIdAsync(Guid transactionId);
    ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction);
    ValueTask<Transaction> RemoveTransactionByIdAsync(Guid transactionId);
}