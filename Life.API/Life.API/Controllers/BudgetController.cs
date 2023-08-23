using Microsoft.AspNetCore.Mvc;

namespace Life.API.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
