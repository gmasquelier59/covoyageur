using EVS.Core.Enums;
using EVS.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace EVS.Api.Controllers
{
    [Tags("Réservations")]
    [ApiController]
    public class ReservationController : Controller
    {
        /// <summary>
        /// Crée une réservation pour un passager sur un trajet défini
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        [HttpPost("/reservation/{rideId}/{userId}")]
        public ActionResult<Reservation> Create(Guid rideId, Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mise à jour d'une réservation (Acception ou Refus des passagers par le conducteur)
        /// </summary>
        /// <param name="id">Identifiant de la réservation</param>
        /// <param name="Status">Identifiant du statut de réservation</param>
        [HttpPut("/reservation/{id}/{status}")]
        public ActionResult<Reservation> Update(Guid id, ReservationStatus Status)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne la liste de toutes les réservations concernant un trajet
        /// </summary>
        /// <param name="rideId">Identifiant de trajet</param>
        [HttpGet("/reservations/{rideId}")]
        public ActionResult<List<Reservation>> AllByRideId(Guid rideId)
        {
            throw new NotImplementedException();
        }
    }
}
