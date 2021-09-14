using AdvancedProgramming_Lesson2.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson2.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
    }
}