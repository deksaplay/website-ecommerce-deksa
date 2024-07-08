using Microsoft.EntityFrameworkCore;
using website_e_commerce.Base;
using website_e_commerce.Data;
using website_e_commerce.Models;

namespace website_e_commerce.Services
{
    public class ReviewService : BaseService<Review>
    {
        public ReviewService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetByProductIdAsync(int productId)
        {
            return await _context.Reviews
                .Include(r => r.User)
                .Include(r => r.Product)
                .Where(r => r.ProductId == productId)
                .ToListAsync();
        }
    }
}