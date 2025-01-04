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
            //  Display the 'ProductName', 'CategoryName' and 'Price' of all the products.

            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();

            var query = from product in products
                join category in categories
                    on product.CategoryId equals category.CategoryId
                select new { product.ProductName, category.CategoryName, product.Price };

            return Ok(query); // query is executed here, as Ok() serialize the data 
        }
    }
}