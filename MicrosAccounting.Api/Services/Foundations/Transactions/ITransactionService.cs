using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Services.Foundations.Transactions;

public interface ITransactionService
{
    ValueTask<Transaction> AddTransactionAsync(Transaction transaction);
    IQueryable<Transaction> RetrieveAllTransactions();
    ValueTask<Transaction?> RetrieveTransactionByIdAsync(Guid transactionId);
    IQueryable<Transaction> RetrieveTransactionByDateAsync(DateTimeOffset transactionDate);
    ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction);
    ValueTask<Transaction> RemoveTransactionByIdAsync(Guid transactionId);
}