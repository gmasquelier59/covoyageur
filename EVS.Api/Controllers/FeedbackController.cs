using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/feedback")]
    [Tags("Feedbacks")]
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
