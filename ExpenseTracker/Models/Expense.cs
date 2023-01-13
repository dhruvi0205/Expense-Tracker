using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public double Amount { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }
    }
}
