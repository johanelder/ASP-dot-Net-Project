using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Model.User User { get; set; }

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

                _db.Users.Add(User);
                _db.SaveChanges();

                TempData["success"] = "User created successfully";

                return RedirectToPage("Index");
            }

            return Page();

        }
    }
}
