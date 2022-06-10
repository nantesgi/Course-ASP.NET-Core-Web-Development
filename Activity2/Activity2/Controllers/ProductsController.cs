using Microsoft.AspNetCore.Mvc;

namespace Activity2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;   
            return View();
        }
    }
}
