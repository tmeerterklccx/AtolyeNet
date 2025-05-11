using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AtolyeNet.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactService.TInsert(contact);
            ViewBag.Contact = "Başarıyla Gönderildi.";
            return View();
        }
        public IActionResult Delete(Contact contact)
        {
            _contactService.TDelete(contact);
            return RedirectToAction("Index");
        }
    }
}
