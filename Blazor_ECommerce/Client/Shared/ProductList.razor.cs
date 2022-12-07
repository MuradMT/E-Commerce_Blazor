

using Blazor_ECommerce.Shared;
using Blazor_ECommerce.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;

namespace Blazor_ECommerce.Client.Shared
{
    public partial class ProductList
    {
        //Mock Data
        [Parameter]
        public string Name { get; set; }
        private List<Product> products = new List<Product>();
        protected override async Task OnInitializedAsync()
        {
            var result = await http.GetFromJsonAsync<List<Product>>("api/Product/Get");
            if(result != null) products = result;
            
        }
    }
}
