using Microsoft.EntityFrameworkCore;
using YosBookShop.Model;

namespace YosBookShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<BookType> BookTypes { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
