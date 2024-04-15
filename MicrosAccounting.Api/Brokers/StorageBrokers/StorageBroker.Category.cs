using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private DbSet<Category> Categories { get; set; }

    public async ValueTask<Category> InsertCategoryAsync(Category category) =>
        await this.InsertAsync(category);
    
    public IQueryable<Category> SelectAllCategories() =>
        this.SelectAll<Category>();

    public async ValueTask<Category?> SelectCategoryByIdAsync(Guid categoryId) =>
        await this.SelectAsync<Category>(categoryId);

    public async ValueTask<Category> UpdateCategoryAsync(Category category) =>
        await this.UpdateAsync(category);

    public async ValueTask<Category?> DeleteCategoryByIdAsync(Guid categoryId)
    {
        var maybeCategory = await SelectCategoryByIdAsync(categoryId);
        return await this.DeleteAsync(maybeCategory);
    }
}