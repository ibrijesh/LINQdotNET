using LINQdotNET.Model;

namespace LINQdotNET.Service;

public interface ICategoryService
{
    public List<Category> GetAllCategories();
}