using Microsoft.EntityFrameworkCore;

namespace Mission11_Burton.Models
{
    public class Bookstore : DbContext
    {
        public Bookstore(DbContextOptions<Bookstore> options) : base(options) { }
        public DbSet<Books> Books { get; set; }
    }
}
