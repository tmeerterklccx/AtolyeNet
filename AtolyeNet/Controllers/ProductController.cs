using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(int id , Product product)
        {
            var values = _productService.TGetByID(id);
            values.Name = product.Name;
            values.Description= product.Description;
            values.ProductText = product.ProductText;
            values.ImgText = product.ImgText;
            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Product product)
        {
            _productService.TDelete(product);
            return RedirectToAction("Index");
        }
    }
}
