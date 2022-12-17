using Blazor_ECommerce.Server.Data;
using Blazor_ECommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_ECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        
        [HttpGet("GetProducts")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
          
            var result= await _productService.GetAllProducts();
            return Ok(result);
        }
        [HttpGet("GetProduct/{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int id)
        {

            var result = await _productService.GetProduct(id);
            return Ok(result);
        }
    }
}
