using MicrosAccounting.Api.Models.Categories;

namespace MicrosAccounting.Api.Services.Foundations;

public interface ICategoryService
{
    ValueTask<Category> AddCategoryAsync(Category category);
    IQueryable<Category> RetrieveAllCategories();
    ValueTask<Category> RetrieveCategoryByIdAsync(Guid categoryId);
    ValueTask<Category?> RetrieveCategoryByNameAsync(string categoryName);
    ValueTask<Category> RetrieveCategoryByTypeAsync(CategoryAccount categoryType);
    ValueTask<Category> ModifyCategoryAsync(Category category);
    ValueTask<Category> RemoveCategoryByIdAsync(Guid categoryId);
}