using website_e_commerce.Data;
using website_e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using website_e_commerce.Base;
namespace website_e_commerce.Services
{
    public class WishlistService : BaseService<Wishlist>
    {
        public WishlistService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Wishlist>> GetByUserIdAsync(int userId)
        {
            return await _context.Wishlists.Where(w => w.UserId == userId).ToListAsync();
        }
    }
}