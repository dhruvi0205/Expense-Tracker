using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string? Title { get; set; } = string.Empty;

        [Required]
        public int Limit { get; set; }
    }
}
