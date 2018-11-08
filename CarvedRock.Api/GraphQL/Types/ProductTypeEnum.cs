using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ProductTypeEnum: EnumerationGraphType<ProductType>
    {
        public ProductTypeEnum()
        {
            Name = "ProductType";
            Description = "The type of product";
        }
    }
}
