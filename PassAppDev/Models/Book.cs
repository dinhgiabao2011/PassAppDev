using System.ComponentModel.DataAnnotations;

namespace PassAppDev.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title cannot be null ...")]
        [StringLength(255)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author cannot be null ...")]
        [StringLength(100)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price cannot be null ...")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Description cannot be null ...")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity cannot be null ...")]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
