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
            // display the product names of all the products

            var products = productService.GetAllProducts();

            var query = from product in products
                select product.ProductName;

            return Ok(query); // query is executed here, as Ok() serialize the data 
        }
    }
}