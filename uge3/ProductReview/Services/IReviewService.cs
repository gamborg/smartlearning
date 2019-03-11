using System.Collections.Generic;
using System.Threading.Tasks;
using ProductReview.Models;

namespace ProductReview.Services
{
    public interface IReviewService
    {
        Task<bool> AddReview(Review model);
        Task<IEnumerable<Review>> GetReviews();
    }
}