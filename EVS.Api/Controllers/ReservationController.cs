using EVS.Api.Services;
using EVS.Core.Enums;
using EVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVS.Api.Controllers
{
    [Tags("Réservations")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        /// <summary>
        /// Crée une réservation pour un passager sur un trajet défini
        /// </summary>
        /// <param name="rideId">Identifiant du trajet</param>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        [HttpPost("/reservation/{rideId}/{userId}")]
        public async Task<ActionResult<Reservation>> Create(Guid rideId, Guid userId)
        {
            Reservation? reservation = await _reservationService.Create(rideId, userId);

            if (reservation == null)
                return BadRequest();

            return Ok(reservation);
        }

        /// <summary>
        /// Mise à jour d'une réservation
        /// </summary>
        /// <param name="id">Identifiant de la réservation</param>
        /// <param name="status">Identifiant du statut de réservation</param>
        [HttpPut("/reservation/{id}/{status}")]
        public async Task<ActionResult<Reservation>> Update(Guid id, ReservationStatus status)
        {
            Reservation? reservation = await _reservationService.UpdateStatus(id, status);

            if (reservation == null)
                return NotFound();

            return Ok(reservation);
        }

        /// <summary>
        /// Retourne la liste de toutes les réservations concernant un trajet
        /// </summary>
        /// <param name="rideId">Identifiant de trajet</param>
        [HttpGet("/reservations/{rideId}")]
        public async Task<ActionResult<List<Reservation>>> AllByRideId(Guid rideId)
        {
            return await _reservationService.GetAllByRideId(rideId);
        }
    }
}
