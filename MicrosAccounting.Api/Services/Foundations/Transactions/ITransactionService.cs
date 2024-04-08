using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Services.Foundations.Transactions;

public interface ITransactionService
{
    ValueTask<Transaction> AddTransactionAsync(Transaction transaction);
    IQueryable<Transaction> RetrieveAllTransactions();
    ValueTask<Transaction?> RetrieveTransactionByIdAsync(Guid transactionId);
    IQueryable<Transaction> RetrieveTransactionByDateAsync(DateTime transactionDate);
    IQueryable<Transaction> RetrieveTransactionBetweenDateTime(DateTime startDate, DateTime endDate);
    ValueTask<Transaction> ModifyTransactionAsync(Transaction transaction);
    ValueTask<Transaction> RemoveTransactionByIdAsync(Guid transactionId);
}