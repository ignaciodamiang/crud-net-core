using Microsoft.AspNetCore.Mvc;

namespace CrudNetCore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
