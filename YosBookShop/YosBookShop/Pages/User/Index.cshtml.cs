using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YosBookShop.Data;
using YosBookShop.Model;

namespace YosBookShop.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DbSet<Model.User> User { get; set; }

        public int Counter { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            User = _db.Users;
        }

        public void OnPost()
        {

        }
    }
}
