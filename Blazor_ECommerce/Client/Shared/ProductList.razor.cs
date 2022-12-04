

using Blazor_ECommerce.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Blazor_ECommerce.Client.Shared
{
    public partial class ProductList
    {
        //Mock Data
        [Parameter]
        public string Name { get; set; }
        List<Product> p = new List<Product>
        {
            new Product
            {
                Id=1,
                Description="First",
                ImageUrl="Some",
                Price=123,
                Tittle="bir"
            },
            new Product
            {
                Id=2,
                Description="Second",
                ImageUrl="Some1",
                Price=124,
                Tittle="iki"
            },
            new Product
            {
                Id=3,
                Description="Third",
                ImageUrl="Some2",
                Price=124,
                Tittle="uc"
            },

        };
    }
}
