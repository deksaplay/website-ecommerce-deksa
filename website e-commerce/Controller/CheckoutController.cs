using Microsoft.AspNetCore.Mvc;
using website_e_commerce.Models;
using website_e_commerce.Services;

using System.Threading.Tasks;

namespace website_e_commerce.Controller
{
    public class CheckoutController : BaseController
    {
        private readonly CheckoutService _checkoutService;

        public CheckoutController(CheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }

        [HttpPost("{userId}")]
        public async Task<Order> Checkout(int userId)
        {
            return await _checkoutService.CheckoutAsync(userId);
        }
    }
}
