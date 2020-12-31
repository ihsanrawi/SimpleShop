using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.ApplicationCore.Interfaces;

namespace SimpleShop.Web.Controllers.Api
{
    public class ProductsController : BaseApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Products()
        {
            var product = await _productService.GetAllProduct();
            
            if (product == null)
            {
                return BadRequest();
            }
            
            return Ok(product);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Product(int id)
        {
            var product = await _productService.GetProductById(id);
            
            if (product == null)
            {
                return BadRequest();
            }
            
            return Ok(product);
        }
    }
}