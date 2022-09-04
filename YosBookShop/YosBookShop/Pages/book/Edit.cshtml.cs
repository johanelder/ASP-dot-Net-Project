using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.book
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Book Book { get; set; }


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            Book = _db.Books.Find(Id);

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.Books.Update(Book);
                _db.SaveChanges();

                TempData["updated"] = "Book updated successfully";

                return RedirectToPage("Index");


            }



            return Page();
        }
    }
}
