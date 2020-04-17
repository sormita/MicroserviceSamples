using GraphQL.Types;
using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.GraphQL.GraphQLTypes
{
    public class ProductReviewType: ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(x => x.ProductReviewId, type: typeof(IdGraphType)).Description("some desc here");
            Field(x => x.ProductId).Description("some desc here");
            Field("reviewername", x => x.ReviewerName).Description("some desc here");            
            Field("reviewdate",x => x.ReviewDate).Description("some desc here");
            Field("emailaddress", x => x.EmailAddress).Description("some desc here");
            Field("rating", x => x.Rating).Description("some desc here");
            Field("comments",x => x.Comments).Description("some desc here");
            Field("modifieddate", x => x.ModifiedDate).Description("some desc here");
        }
        
    }
}
