using e_commerce.Data;
using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Base;
namespace e_commerce.Services
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