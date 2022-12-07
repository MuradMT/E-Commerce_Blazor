using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_ECommerce.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Tittle { get; set; }=string.Empty;
        public string Description { get; set; }= string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(15,5)")]
        public decimal Price { get; set; }  

    }
}
