using System;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockSchema: Schema
    {
        public CarvedRockSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CarvedRockQuery>();
            Mutation = serviceProvider.GetRequiredService<CarvedRockMutation>();
            Subscription = serviceProvider.GetRequiredService<CarvedRockSubscription>();
        }
    }
}
