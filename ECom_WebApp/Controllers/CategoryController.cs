using ECom_WebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECom_WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _DbContext;
        public CategoryController(ApplicationDBContext DbContext)
        {
            _DbContext = DbContext;
        }
        public IActionResult Index()
        {
            var objCategoryList = _DbContext.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
