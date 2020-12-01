namespace CarvedRock.Web.Models
{
    public class ProductReviewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
    }

    public class ProductReviewResponse
    {
        public ProductReviewModel CreateReview { get; set; }
    }
    
    public class ProductReviewSubscriptionResponse
    {
        public ProductReviewModel ReviewAdded { get; set; }
    }
}
