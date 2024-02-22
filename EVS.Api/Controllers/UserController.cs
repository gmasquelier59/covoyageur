using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/user")]
    [Tags("Users")]
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
