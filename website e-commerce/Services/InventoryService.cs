using website_e_commerce.Base;
using website_e_commerce.Data;
using website_e_commerce.Models;
namespace website_e_commerce.Services
{
    public class InventoryService : BaseService<Inventory>
    {
        public InventoryService(ApplicationDbContext context) : base(context)
        {
        }
    }
}