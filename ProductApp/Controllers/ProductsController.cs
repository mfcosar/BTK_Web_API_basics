using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        //ctrl . deyince generate constructor geliyor
        public ProductsController(ILogger<ProductsController> logger)
        { //injection
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, ProductName="Computer"},
                new Product { Id = 2, ProductName="Keyboard"},
                new Product { Id = 3,ProductName="Mouse"}
            };
            _logger.LogInformation("GetAllProducts method has been called");
            return Ok(products);
        }


        [HttpPost]
        public IActionResult GetAllProducts([FromBody]Product product)
        {
            _logger.LogWarning("Product has ben formed");
            return StatusCode(201);
        }
    }
}
