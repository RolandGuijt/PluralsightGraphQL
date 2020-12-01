using System;
using System.Threading.Tasks;
using CarvedRock.Web.Models;
using GraphQL.Client;
using GraphQL.Client.Http;

namespace CarvedRock.Web.Clients
{
    public class ProductGraphClient
    {
        private readonly GraphQLHttpClient _client;

        public ProductGraphClient(GraphQLHttpClient client)
        {
            _client = client;
        }

        public async Task<ProductModel> GetProduct(int id)
        {
            var query = new GraphQLHttpRequest
            {
                Query = @" 
                query productQuery($productId: ID!)
                { product(id: $productId) 
                    { id name price rating photoFileName description stock introducedAt 
                      reviews { title review }
                    }
                }",
                Variables = new {productId = id}
            };
            var response = await _client.SendQueryAsync<ProductResponse>(query);
            return response.Data.Product;
        }

        public async Task AddReview(ProductReviewModel review)
        {
            var query = new GraphQLHttpRequest
            {
                Query = @" 
                mutation($review: reviewInput!)
                {
                    createReview(review: $review)
                    {
                        id
                    }
                }",
                Variables = new { review }
            };
            var response = await _client.SendQueryAsync<ProductReviewResponse>(query);
            var reviewReturned = response.Data.CreateReview;
        }

        public void SubscribeToUpdates()
        {
            var query = new GraphQLHttpRequest
            {
                Query = @"subscription { reviewAdded { title productId } }"
            };

            var result = _client.CreateSubscriptionStream<ProductReviewSubscriptionResponse>(query);

            result.Subscribe(response =>
            {
                var review = response.Data;
            });
        }
    }
}
