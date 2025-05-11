using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
