using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class ProductDTO
    {
        public int CageId { get; set; }
        public string? CageName { get; set; }
        public string? CategoryName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Material { get; set; }
        public string? Size { get; set; }
        public int? Bar { get; set; }
        public string? Description { get; set; }
        public string? DiscountName { get; set; }
    }
}
