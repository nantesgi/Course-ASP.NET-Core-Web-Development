using Microsoft.AspNetCore.Mvc;

namespace Activity2.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aproved(double amount=100.0, string paymentMethod="Credit Card")
        {
            ViewBag.Amount = amount;
            ViewBag.PaymentMethod = paymentMethod;

            return View();
        }
    }
}
