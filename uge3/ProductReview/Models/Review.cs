using System.ComponentModel.DataAnnotations;

namespace ProductReview.Models
{
    public class Review
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [Range(typeof(int), "0", "10")]
        public int Rate { get; set; }
    }
}