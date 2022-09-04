using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.book
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Book Book { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            Book = _db.Books.Find(Id);
        }

        public IActionResult OnPost()
        {
            var bookFromDb = _db.Books.Find(Book.Id);
            _db.Books.Remove(bookFromDb);
            _db.SaveChanges();

            TempData["delete"] = "Book deleted successfully";

            return RedirectToPage("Index");

        }
    }
}
