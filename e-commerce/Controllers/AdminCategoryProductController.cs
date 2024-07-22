using e_commerce.Services;
using Microsoft.AspNetCore.Mvc;
using e_commerce.Models;

using System.Collections.Generic;
using System.Threading.Tasks;
using e_commerce.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace e_commerce.Controllers
{
    [Route("admin/[controller]")]
    public class AdminCategoryProductController : Controller
    {
        private readonly CategoryService _categoryService;
        public AdminCategoryProductController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var cats = await _categoryService.GetAllAsync();

            return View(cats);
        }

      //  public async Task<IActionResult> Create([FromBody] Category category)
      //  {
      //      var createdCategory = await _categoryService.CreateAsync(category);
       //     return RedirectToAction(nameof(Index)); // or return a appropriate response
       // }
    }
}

