using CarvedRock.Api.Data.Entities;
using CarvedRock.Api.GraphQL.Types;
using CarvedRock.Api.Repositories;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockMutation : ObjectGraphType
    {
        public CarvedRockMutation(ProductReviewRepository reviewRepository, ReviewMessageService messageService)
        {
            Field<ProductReviewType>(
                "createReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductReviewInputType>> {Name = "review"}), 
                resolve: context =>
                {
                    var review = context.GetArgument<ProductReview>("review");
                    messageService.AddMessage(review);
                    return reviewRepository.AddReview(review);
                });
        }
    }
}
