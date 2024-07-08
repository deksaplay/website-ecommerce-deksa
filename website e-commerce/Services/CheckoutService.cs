using ECommerce.Data;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using website_e_commerce.Base;
using website_e_commerce.Data;
using website_e_commerce.Models;
namespace website_e_commerce.Services
{
    public class CheckoutService : BaseService<Order>
    {
        public CheckoutService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Order> CheckoutAsync(int userId)
        {
            var cartItems = await _context.CartItems.Where(ci => ci.UserId == userId).ToListAsync();

            if (cartItems == null || !cartItems.Any())
            {
                return null;
            }

            var order = new Order
            {
                UserId = userId,
                Items = cartItems,
                TotalPrice = cartItems.Sum(ci => ci.Price * ci.Quantity),
                Status = "Pending"
            };

            _context.Orders.Add(order);
            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            return order;
        }
    }
}