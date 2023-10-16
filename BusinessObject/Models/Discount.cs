using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Cages = new HashSet<Cage>();
        }

        public int DiscountId { get; set; }
        public string? DiscountName { get; set; }
        public DateTime? DiscountStart { get; set; }
        public DateTime? DiscountFinish { get; set; }
        public decimal? Discount1 { get; set; }
        public string? DiscountStatus { get; set; }

        public virtual ICollection<Cage> Cages { get; set; }
    }
}
