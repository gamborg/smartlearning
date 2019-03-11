using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductReview.Models;

namespace ProductReview.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ReviewContext _context;
        public ReviewService(ReviewContext context) 
        {
            _context = context;
        }

        public async Task<bool> AddReview(Review model)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Review>> GetReviews() 
        {
            var list = await _context.Reviews.ToAsyncEnumerable().ToList();
            return list;
        }
    }
}