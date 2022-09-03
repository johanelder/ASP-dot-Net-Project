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
        public BookType BookType { get; set; }


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            BookType = _db.BookTypes.Find(Id);
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.BookTypes.Update(BookType);
                _db.SaveChanges();

                TempData["updated"] = "Book type updated successfully";

                return RedirectToPage("Index");


            }



            return Page();
        }
    }
}
