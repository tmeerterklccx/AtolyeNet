using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
