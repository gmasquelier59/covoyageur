using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/ride")]
    [Tags("Trajets")]
    public class RideController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
