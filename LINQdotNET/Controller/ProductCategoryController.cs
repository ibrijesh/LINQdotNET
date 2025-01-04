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
            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();

            var result = new
            {
                Products = products,
                Categories = categories
            };

            return Ok(result);
        }
    }
}