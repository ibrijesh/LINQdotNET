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
            //  Display the category name and the total quantity of products available in each category in the ascending order of category Id

            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();

            var query = from product in products
                group product by product.CategoryId
                into g
                join category in categories 
                    on g.Key equals category.CategoryId
                orderby g.Key ascending 
                select new { CategoryName = category.CategoryName, Quantity = g.Sum(x => x.QuantityAvailable) };

            return Ok(query); // query is executed here, as Ok() serialize the data 
        }
    }
}