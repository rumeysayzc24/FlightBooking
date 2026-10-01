using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents
{
    public class _AdminTopbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
