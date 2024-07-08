namespace website_e_commerce.Models
{
    public class CartItem : BaseEntity
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}