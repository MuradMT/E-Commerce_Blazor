using Blazor_ECommerce.Server.Data;
using Blazor_ECommerce.Shared;

namespace Blazor_ECommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _db;

        public ProductService(DataContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            //there are two way for getting data from database the examples
            //shown below
            //var r=await _db.Set<Product>().ToListAsync();
            var result = await _db.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                Data = result
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int id)
        {
            var response = new ServiceResponse<Product>();
            var product=await _db.Products.FindAsync(id);
            if(product == null)
            {
                response.Success = false;
                response.Message = "this is not exist";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }
    }
}
