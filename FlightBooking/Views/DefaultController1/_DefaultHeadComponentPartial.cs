using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Views.DefaultController1
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
          return View();
        }
    }
}
