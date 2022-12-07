using Blazor_ECommerce.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_ECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _db;

        public ProductController(DataContext db)
        {
            _db = db;
        }
        
        [HttpGet("Get")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //there are two way for getting data from database the examples
            //shown below
            //var r=await _db.Set<Product>().ToListAsync();
            var result= await _db.Products.ToListAsync();
            return Ok(r);
        }
    }
}
