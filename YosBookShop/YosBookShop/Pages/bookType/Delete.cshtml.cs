using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.bookType
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BookType BookType { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            BookType = _db.BookTypes.Find(Id);
        }

        public IActionResult OnPost()
        {
            var bikeTypeFromDb = _db.BookTypes.Find(BookType.Id);
            _db.BookTypes.Remove(bikeTypeFromDb);
            _db.SaveChanges();

            TempData["delete"] = "Book type deleted successfully";

            return RedirectToPage("Index");

        }

    }
}
