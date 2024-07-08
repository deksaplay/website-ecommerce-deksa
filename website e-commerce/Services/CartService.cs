using website_e_commerce.Data;
using website_e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website_e_commerce.Base;
namespace website_e_commerce.Services
{
    public class CartService : BaseService<CartItem>
    {
        public CartService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsByUserIdAsync(int userId)
        {
            return await _context.CartItems.Where(ci => ci.UserId == userId).ToListAsync();
        }
    }
}