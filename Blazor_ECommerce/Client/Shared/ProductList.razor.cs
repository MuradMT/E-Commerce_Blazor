

using Blazor_ECommerce.Shared;
using Blazor_ECommerce.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using Blazor_ECommerce.Client.Services.ProductService;
using static System.Net.WebRequestMethods;

namespace Blazor_ECommerce.Client.Shared
{
    public partial class ProductList
    {
        protected override async Task OnInitializedAsync()
        {
            await _prod.GetProducts();

        }
    }
}
