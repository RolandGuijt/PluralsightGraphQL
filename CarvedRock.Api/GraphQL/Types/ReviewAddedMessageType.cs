using CarvedRock.Api.GraphQL.Messaging;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ReviewAddedMessageType: ObjectGraphType<ReviewAddedMessage>
    {
        public ReviewAddedMessageType()
        {
            Field(t => t.ProductId);
            Field(t => t.Title);
        }
    }
}
