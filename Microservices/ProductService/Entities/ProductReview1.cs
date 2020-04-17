using System;
using System.Collections.Generic;

namespace ProductService.Entities
{
    public partial class ProductReview1
    {
        public int ProductReviewId { get; set; }
        public int ProductId { get; set; }
        public string ReviewerName { get; set; }
        public DateTime ReviewDate { get; set; }
        public string EmailAddress { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product1 Product { get; set; }
    }
}
