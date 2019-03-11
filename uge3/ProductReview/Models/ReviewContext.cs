using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProductReview.Models
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base (options) 
        {

        }

        public DbSet<Review> Reviews { get; set; }
    }
}