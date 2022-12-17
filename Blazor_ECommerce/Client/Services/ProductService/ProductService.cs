
using Blazor_ECommerce.Shared;

namespace Blazor_ECommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> products { get ; set ; }= new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/GetProduct/{id}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = await
                _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product/GetProducts");
            if (result != null&&result.Data!=null)
                products = result.Data;
        }
    }
}
