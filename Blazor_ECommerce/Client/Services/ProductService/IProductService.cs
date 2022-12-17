

using Blazor_ECommerce.Shared;

namespace Blazor_ECommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> products { get; set; }
        Task GetProducts();
        
        Task<ServiceResponse<Product>> GetProduct(int id);
    }
}
