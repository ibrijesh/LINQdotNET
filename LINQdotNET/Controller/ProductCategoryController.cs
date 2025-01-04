using LINQdotNET.Model;
using LINQdotNET.Repository;
using LINQdotNET.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LINQdotNET.Controller
{
    [Route("api/productCategories")]
    [ApiController]
    public class ProductCategoryController(IProductService productService, ICategoryService categoryService)
        : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProductCategories()
        {
            //  Display the 'CategoryId' and number of products available in each category. Here, we need to group the data with 'CategoryId'

            var products = productService.GetAllProducts();

            var query = from product in products
                group product by product.CategoryId
                into g
                select new { CategoryId = g.Key, NumberOfProducts = g.Count() };

            return Ok(query); // query is executed here, as Ok() serialize the data 
        }
    }
}