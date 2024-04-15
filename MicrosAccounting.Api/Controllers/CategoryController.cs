using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Services.Foundations.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MicrosAccounting.Api.Controllers;

// [Authorize]
[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }

    [HttpGet]
    public ActionResult<IQueryable<Category>> GetAllCategory()
    {
        IQueryable<Category> categories = this.categoryService.RetrieveAllCategories();
    
        return Ok(categories);
    }
    
    [HttpGet("id/{categoryId}")]
    public async ValueTask<ActionResult<Category>> GetCategoryById(Guid categoryId)
    {
        Category? category = await categoryService.RetrieveCategoryByIdAsync(categoryId);
        
        return Ok(category);
    }
    
    [HttpPost]
    public async ValueTask<ActionResult<Category>> PostCategory(Category category)
    {
        Category addedCategory = await categoryService.AddCategoryAsync(category);

        return Ok(addedCategory);
    }
    
    [HttpPut]
    public async ValueTask<ActionResult<Category>> PutCategory(Category category)
    {
        Category updateCategory = await this.categoryService.ModifyCategoryAsync(category);
        
        return Ok(updateCategory);
    }
    
    [HttpDelete("{categoryId}")]
    
    public async ValueTask<ActionResult<Category>> DeleteByIdCategory(Guid categoryId)
    {
        Category deleteCategory = await this.categoryService.RemoveCategoryByIdAsync(categoryId);
        
        return Ok(deleteCategory);
    }
}