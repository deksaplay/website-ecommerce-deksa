using website_e_commerce.Data;
using website_e_commerce.Models;
using System.Threading.Tasks;
using website_e_commerce.Base;
namespace website_e_commerce.Services
{
    public class PromotionService : BaseService<Promotion>
    {
        public PromotionService(ApplicationDbContext context) : base(context)
        {
        }
    }
}