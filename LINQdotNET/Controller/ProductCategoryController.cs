using LINQdotNET.Model;
using LINQdotNET.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LINQdotNET.Controller
{
    [Route("api/productCategories")]
    [ApiController]
    public class ProductCategoryController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProductCategories()
        {
            var products = productRepository.FetchAllProducts();
            var categories = categoryRepository.FetchAllCategories();

            var result = new
            {
                Products = products,
                Categories = categories
            };

            return Ok(result);
        }
    }
}