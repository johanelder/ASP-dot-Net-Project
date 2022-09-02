using System.ComponentModel.DataAnnotations;

namespace YosBookShop.Model
{
    public class BookType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
