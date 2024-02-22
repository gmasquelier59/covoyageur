using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/reservation")]
    [Tags("Reservations")]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
