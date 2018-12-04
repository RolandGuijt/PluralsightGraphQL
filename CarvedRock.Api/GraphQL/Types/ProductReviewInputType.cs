using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ProductReviewInputType: InputObjectGraphType
    {
        public ProductReviewInputType()
        {
            Name = "reviewInput";
            Field<IdGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("review");
            Field<IntGraphType>("productId");
        }

    }
}
