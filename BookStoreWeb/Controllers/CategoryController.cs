
using Microsoft.AspNetCore.Mvc;
using Store.DataAccess;

namespace BookStoreWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var objCategoryList= _context.Categories.ToList();
            return View();
        }
    }
}
