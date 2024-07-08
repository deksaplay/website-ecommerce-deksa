namespace website_e_commerce.Models
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
    }
}