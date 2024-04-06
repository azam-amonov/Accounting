using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Categories;

namespace MicrosAccounting.Api.Services.Foundations.Categories;

public class CategoryService : ICategoryService
{
    private readonly IStorageBroker storageBroker;

    public CategoryService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    public async ValueTask<Category> AddCategoryAsync(Category category) =>
        await this.storageBroker.InsertCategoryAsync(category);

    public IQueryable<Category> RetrieveAllCategoriesAsync() =>
        this.storageBroker.SelectAllCategories();

    public async ValueTask<Category> ModifyCategoryAsync(Category category) =>
        await this.storageBroker.UpdateCategoryAsync(category);
    
    public async ValueTask<Category> RemoveCategoryAsync(Category category) =>
        await this.storageBroker.DeleteCategoryAsync(category);
}