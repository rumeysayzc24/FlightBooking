using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
