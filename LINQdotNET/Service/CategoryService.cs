using LINQdotNET.Model;
using LINQdotNET.Repository;

namespace LINQdotNET.Service;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    public List<Category> GetAllCategories()
    {
        return categoryRepository.FetchAllCategories();
    }
}