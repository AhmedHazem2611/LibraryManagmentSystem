using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIbraryManagementSystem.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone {  get; set; }
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Borrowing>? Borrowings { get; set;} = new List<Borrowing>();

    }
}
