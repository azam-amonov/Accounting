using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore;

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

    public IQueryable<Category> RetrieveAllCategories() =>
        this.storageBroker.SelectAllCategories();

    public async ValueTask<Category> RetrieveCategoryByIdAsync(Guid categoryId) =>
        await this.storageBroker.SelectCategoryByIdAsync(categoryId);

    public async ValueTask<Category?> RetrieveCategoryByNameAsync(string categoryName)
    {
        var categories =  this.storageBroker.SelectAllCategories();
        var maybeCategory = await categories.FirstOrDefaultAsync(item =>
            item.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

        return maybeCategory;
    }

    public async ValueTask<Category> RetrieveCategoryByTypeAsync(CategoryAccount categoryType)
    {
        var categories =  this.storageBroker.SelectAllCategories();
        var maybeCategory = await categories.FirstOrDefaultAsync(item =>
            item.Accounting == categoryType);
        
        return maybeCategory;
    }

    public async ValueTask<Category> ModifyCategoryAsync(Category category) =>
        await this.storageBroker.UpdateCategoryAsync(category);
    
    public async ValueTask<Category> RemoveCategoryByIdAsync(Guid categoryId) =>
        await this.storageBroker.DeleteCategoryByIdAsync(categoryId);
}