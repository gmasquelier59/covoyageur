using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/ride")]
    [Tags("Rides")]
    public class RideController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
