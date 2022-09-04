using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace YosBookShop.Model
{
    public class Order
    {
        [Key]
            public int Id { get; set; }

            [Required]
            public string Address { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string PostalCode { get; set; }


            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime CreatedOn { get; set; }

            [AllowNull]
            public DateTime ShippedOn { get; set; }

            //public virtual ICollection<Book> Books { get; set; }

            //public virtual User User { get; set; }

            public Order()
            {
                this.CreatedOn = DateTime.Now;
                this.ShippedOn = DateTime.Now;
            }

        }
}

