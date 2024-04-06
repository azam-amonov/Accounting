using MicrosAccounting.Api.Models.Transactions;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    public async ValueTask<Transaction> InsertTransactionAsync(Transaction transaction) =>
        await this.InsertAsync(transaction);
}