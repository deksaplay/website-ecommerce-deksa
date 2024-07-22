using Microsoft.AspNetCore.Mvc;
using website_e_commerce.Base;

namespace website_e_commerce.Controllers
{
    public class HomeController : BaseViewController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
