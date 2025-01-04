using LINQdotNET.Model;

namespace LINQdotNET.Service;

public interface IProductService
{
    public List<Product> GetAllProducts();
}