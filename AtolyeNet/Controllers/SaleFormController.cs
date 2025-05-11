using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class SaleFormController : Controller
    {

        private readonly ISaleManagementService _saleManagementService;

        public SaleFormController(ISaleManagementService saleManagementService)
        {

            _saleManagementService = saleManagementService;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            using var context = new Context();
            var values = context.Products.Find(id);
            ViewBag.ProductName = values.Name;
            return View();

        }
        [HttpPost]
        public IActionResult Index(SaleManagement saleManagement)
        {
            saleManagement.Statu = true;
            _saleManagementService.TInsert(saleManagement);

            ViewBag.Onay = "Başarıyla Gönderildi.";
            return View();
        }
    }
}
