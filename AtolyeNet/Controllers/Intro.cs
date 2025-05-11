using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class Intro : Controller
    {
        private readonly IProductService _product;

        public Intro(IProductService product)
        {
            _product = product;
        }

        public IActionResult Index(int id)
        {
            var values = _product.TGetByID(id);
            ViewBag.ID = values.ID;
            ViewBag.Name = values.Name;
            ViewBag.Description = values.Description;
            ViewBag.ImgText = values.ImgText;
            return View();
        }
    }
}
