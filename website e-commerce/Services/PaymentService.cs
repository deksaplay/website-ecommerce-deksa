using website_e_commerce.Data;
using website_e_commerce.Models;
using System.Threading.Tasks;
using website_e_commerce.Base;
namespace website_e_commerce.Services
{
    public class PaymentService : BaseService<Payment>
    {
        public PaymentService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Payment> ProcessPaymentAsync(Payment payment)
        {
            payment.Status = "Processed";
            return await CreateAsync(payment);
        }
    }
}
