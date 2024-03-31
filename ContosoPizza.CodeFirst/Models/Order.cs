using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; } // Does not allow null
        public DateTime? OrderFulfilled { get; set; } // Allows null

        [Required]
        public int CustomerId { get; set; } // Required Foreign Key property

        // Navigation properties
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; } = null!; // Reference Navigation
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!; // Collection Navigation

    }
}