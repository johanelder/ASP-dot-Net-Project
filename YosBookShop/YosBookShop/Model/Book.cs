using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace YosBookShop.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int PageCount { get; set; }

        //[AllowNull]
        //public BookType? BookType { get; set; }
        public virtual BookType? BookType { get; set; }

    }
}
