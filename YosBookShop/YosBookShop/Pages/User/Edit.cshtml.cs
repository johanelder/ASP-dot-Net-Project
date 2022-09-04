using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.User
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Model.User User { get; set; }


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            User = _db.Users.Find(Id);

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _db.Users.Update(User);
                _db.SaveChanges();

                TempData["updated"] = "User updated successfully";

                return RedirectToPage("Index");


            }



            return Page();
        }
    }
}
