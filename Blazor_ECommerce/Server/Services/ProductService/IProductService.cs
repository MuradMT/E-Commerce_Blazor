using Blazor_ECommerce.Shared;

namespace Blazor_ECommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProducts();
        Task<ServiceResponse<Product>> GetProduct(int id);
    }
}
