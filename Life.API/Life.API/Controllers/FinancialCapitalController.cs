using Microsoft.AspNetCore.Mvc;

namespace Life.API.Controllers
{
    public class FinancialCapitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
