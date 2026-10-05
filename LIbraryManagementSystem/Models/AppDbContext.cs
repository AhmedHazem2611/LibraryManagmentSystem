using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LIbraryManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Member> Members {  get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Books)
                .WithOne(f => f.Category)
                .HasForeignKey(e => e.CategoryId);
            modelBuilder.Entity<Member>()
                .HasMany(e => e.Borrowings)
                .WithOne(f => f.Member)
                .HasForeignKey(e => e.MemberId);
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Borrowings)
                .WithOne(f => f.Book)
                .HasForeignKey(e => e.Id);
        }
    }
}
