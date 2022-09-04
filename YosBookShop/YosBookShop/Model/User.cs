using System.ComponentModel.DataAnnotations;

namespace YosBookShop.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }

        public User()
        {
            this.CreatedOn = DateTime.Now;
        }
    }
}
