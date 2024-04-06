using MicrosAccounting.Api.Models.Categories;

namespace MicrosAccounting.Api.Services.Foundations;

public interface ICategoryService
{
    ValueTask<Category> AddCategoryAsync(Category category);
    IQueryable<Category> RetrieveAllCategoriesAsync();
    ValueTask<Category> ModifyCategoryAsync(Category category);
    ValueTask<Category> RemoveCategoryAsync(Category category);
}