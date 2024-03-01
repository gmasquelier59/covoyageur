﻿using EVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Tags("Feedbacks")]
    [ApiController]
    public class FeedbackController : Controller
    {
        /// <summary>
        /// Retourne les feedbacks d'un trajet à partir de son id
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        [HttpGet("/feedbacks/ride/{rideId}")]
        public ActionResult<List<Feedback>> GetAllByRideId(Guid rideId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les feedbacks d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        [HttpGet("/feedbacks/user/{userId}")]
        public ActionResult<List<Feedback>> GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ajoute un nouveau feedback à un trajet associé à l'utilisateur connecté
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        [HttpPost("/feedback/{rideId}")]
        public ActionResult<Feedback> Create(Guid rideId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Met à jour un feedback à partir de son id
        /// </summary>
        /// <param name="id">Identifiant du feedback</param>
        [HttpPut("/feedback/{id}")]
        public ActionResult<Feedback> Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
