using ProductReview.Models;

namespace ProductReview.Services
{
    public interface IReviewService
    {
        void AddReview(Review model);
    }
}