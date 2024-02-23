using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Route("/feedback")]
    [Tags("Feedbacks")]
    [ApiController]
    public class FeedbackController : Controller
    {
        /// <summary>
        /// Retourne les feedbacks d'un trajet à partir de son id
        /// </summary>
        [HttpGet("/feedbacks/ride/{rideId}")]
        public IActionResult GetByRideId(int rideId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les feedbacks d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="userId"></param>
        [HttpGet("/feedbacks/user/{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ajoute un nouveau feedback à un trajet associé à l'utilisateur connecté
        /// </summary>
        [HttpPost("/feedback/{rideId}")]
        public IActionResult Create(int rideId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Met à jour un feedback à partir de son id
        /// </summary>
        [HttpPut("/feedback/{id}")]
        public IActionResult Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
