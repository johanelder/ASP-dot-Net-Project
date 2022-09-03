using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.bookType
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BookType? BookType { get; set; }


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            BookType = _db.BookTypes.Find(id);
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.BookTypes.Update(BookType);
                _db.SaveChanges();

                TempData["success"] = "Book type updated successfully";

                return RedirectToPage("Index");


            }



            return Page();
        }
    }
}
