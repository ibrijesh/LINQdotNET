using LINQdotNET.Model;
using LINQdotNET.Repository;

namespace LINQdotNET.Service;

public class ProductService(IProductRepository productRepository) : IProductService
{
    public List<Product> GetAllProducts()
    {
        return productRepository.FetchAllProducts();
    }
}