using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class OrderDetail
    {
        public int DetailId { get; set; }
        public int? OrderId { get; set; }
        public int? CageId { get; set; }
        public decimal? DetailPrice { get; set; }
        public int? DetailQuantity { get; set; }

        public virtual Cage? Cage { get; set; }
        public virtual Order? Order { get; set; }
    }
}
