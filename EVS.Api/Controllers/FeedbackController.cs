using EVS.Api.DTOs;
using EVS.Api.Services;
using EVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Tags("Feedbacks")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }
        /// <summary>
        /// Retourne les feedbacks d'un trajet à partir de son id
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        [HttpGet("/feedbacks/ride/{rideId}")]
        public async Task<ActionResult<List<Feedback>>> GetAllByRideId(Guid rideId)
        {
            var feedbacks = await _feedbackService.GetAllByRideId(rideId);
            return Ok(feedbacks);
        }

        /// <summary>
        /// Retourne les feedbacks d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        [HttpGet("/feedbacks/user/{userId}")]
        public async Task<ActionResult<List<Feedback>>> GetAllByUserId(Guid userId)
        {
            return await _feedbackService.GetAllByUserId(userId);
        }

        /// <summary>
        /// Ajoute un nouveau feedback à un trajet associé à l'utilisateur connecté
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        [HttpPost("/feedback/{rideId}")]
        public async Task<ActionResult<Feedback>> Create(Guid rideId, [FromBody] FeedbackDTO feedbackDTO)
        {
            Feedback? feedback = await _feedbackService.Create(rideId, feedbackDTO);

            if (feedback == null)
                return BadRequest();

            return Ok(feedback);
        }

        /// <summary>
        /// Met à jour un feedback à partir de son id
        /// </summary>
        /// <param name="id">Identifiant du feedback</param>
        [HttpPut("/feedback/{id}")]
        public async Task<ActionResult<Feedback>> Update(Guid id, [FromBody] FeedbackDTO feedbackDTO)
        {
            Feedback? feedback = await _feedbackService.Update(id, feedbackDTO);

            if (feedback == null)
                return NotFound();

            return Ok(feedback);
        }
    }
}