using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Rating
    {
        public Rating()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int RatingId { get; set; }
        public int? RatingNumber { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
