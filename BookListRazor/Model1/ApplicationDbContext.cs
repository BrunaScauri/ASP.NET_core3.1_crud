using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Model1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book>  Book { get; set; }
    }
}
