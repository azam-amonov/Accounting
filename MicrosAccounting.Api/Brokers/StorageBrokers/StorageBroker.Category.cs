using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private DbSet<Category> Categories { get; set; }

    public async ValueTask<Category> InsertCategoryAsync(Category category) =>
        await this.InsertAsync(category);
}