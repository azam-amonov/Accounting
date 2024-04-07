using MicrosAccounting.Api.Models.Categories;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<Category> InsertCategoryAsync(Category category);
    IQueryable<Category> SelectAllCategories();
    ValueTask<Category> SelectCategoryByIdAsync(Guid categoryId);
    ValueTask<Category> UpdateCategoryAsync(Category category);
    ValueTask<Category> DeleteCategoryAsync(Category category);
}