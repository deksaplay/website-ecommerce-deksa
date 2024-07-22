using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Order : BaseEntity
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string OrderNumber { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        //public virtual List<OrderItem> Items { get; set; }

    }
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}