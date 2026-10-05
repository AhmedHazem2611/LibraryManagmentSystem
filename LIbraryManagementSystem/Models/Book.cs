using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIbraryManagementSystem.Models
{
    [Index(nameof(ISBN), IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        [Range(0,double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public bool IsAvaiable { get; set; } = true;
        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Borrowing>? Borrowings { get; set; } = new List<Borrowing>();
    }
}
