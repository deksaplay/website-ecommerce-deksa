using website_e_commerce.Base;
using website_e_commerce.Data;
using website_e_commerce.Models;
namespace website_e_commerce.Services
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }
    }
}