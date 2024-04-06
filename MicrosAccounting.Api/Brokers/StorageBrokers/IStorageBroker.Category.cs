using MicrosAccounting.Api.Models.Categories;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<Category> InsertCategoryAsync(Category category);
    IQueryable<Category> SelectAllCategories();
}