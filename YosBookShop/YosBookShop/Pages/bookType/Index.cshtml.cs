using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YosBookShop.Data;
using YosBookShop.Model;
using YosBookShop.Migrations;
using BookTypes = YosBookShop.Model.BookType;

namespace YosBookShop.Pages.bikeType
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DbSet<BookType> BookTypes { get; set; }

        public int Counter { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            BookTypes = _db.BookTypes;
        }

        public void OnPost()
        {

        }
    }
}
