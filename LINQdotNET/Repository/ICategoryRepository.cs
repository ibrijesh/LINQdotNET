using LINQdotNET.Model;

namespace LINQdotNET.Repository;

public interface ICategoryRepository
{
    public List<Category> FetchAllCategories();
}