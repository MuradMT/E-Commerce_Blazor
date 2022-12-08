
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

        public async Task GetProducts()
        {
            var result = await
                _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product/Get");
            if (result != null&&result.Data!=null)
                products = result.Data;
        }
    }
}
