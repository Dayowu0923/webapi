using Microsoft.AspNetCore.Mvc;

namespace WebApplication13.Controllers
{
    public class Cog1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
