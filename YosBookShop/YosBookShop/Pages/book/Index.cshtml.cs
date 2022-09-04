using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.book
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DbSet<Book> Books { get; set; }

        public int Counter { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Books = _db.Books;
        }

        public void OnPost()
        {

        }
    }
}
