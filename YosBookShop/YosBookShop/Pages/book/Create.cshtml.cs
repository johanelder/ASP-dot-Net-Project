using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.book
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

            [BindProperty]
            public Book Book { get; set; }

            public IEnumerator<BookType> BookType { get; set; }

            public List<BookType> BookTypes { get; set; }

            public CreateModel(ApplicationDbContext db)
            {
                _db = db;
            }

            public void OnGet()
            {

            }

            public IActionResult OnPost()
            {
                if (ModelState.IsValid)
                {

                    _db.Books.Add(Book);
                    _db.SaveChanges();

                    TempData["success"] = "Book Type created successfully";

                    return RedirectToPage("Index");
                }

                return Page();

            }


    }
}
