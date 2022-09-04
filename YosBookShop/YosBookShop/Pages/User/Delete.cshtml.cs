using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.User
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Model.User User { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            User = _db.Users.Find(Id);
        }

        public IActionResult OnPost()
        {
            var userFromDb = _db.Users.Find(User.Id);
            _db.Users.Remove(userFromDb);
            _db.SaveChanges();

            TempData["delete"] = "User deleted successfully";

            return RedirectToPage("Index");

        }
    }
}
