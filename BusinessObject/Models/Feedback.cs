using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int? UserId { get; set; }
        public int? CageId { get; set; }
        public int? OrderId { get; set; }
        public int? RatingId { get; set; }
        public string? FeedBackName { get; set; }
        public string? FeedBackContent { get; set; }

        public virtual Cage? Cage { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Rating? Rating { get; set; }
        public virtual User? User { get; set; }
    }
}
