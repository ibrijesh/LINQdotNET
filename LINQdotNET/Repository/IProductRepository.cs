using LINQdotNET.Model;

namespace LINQdotNET.Repository;

public interface IProductRepository
{
    public List<Product> FetchAllProducts();
}