using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;
using EVS.Api.Services;

namespace EVS.Api.Controllers
{
    [Tags("Trajets")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly IRideService _rideService;

        public RideController(IRideService rideService)
        {
            _rideService = rideService;
        }

        /// <summary>
        /// Retourne la liste des trajets correspondants aux 3 critères
        /// </summary>
        /// <param name="startCity">Nom de la ville de départ</param>
        /// <param name="endCity">Nom de la ville de d'arrivée</param>
        /// <param name="departure">Date de départ</param>
        [HttpGet("/rides/{startCity}/{endCity}/{departure}")]
        public async Task<ActionResult<List<Ride>>> AllWithEndCity(string startCity, string endCity, DateTime departure)
        {
            List<Ride> rides = await _rideService.GetAll(startCity, endCity, departure);
            return Ok(rides);
        }

        /// <summary>
        /// Retourne la liste des trajets correspondants aux critères départ/date sans destination précise
        /// </summary>
        /// <param name="startCity">Nom de la ville de départ</param>        
        /// <param name="departure">Date de départ</param>
        [HttpGet("/rides/{startCity}/{departure}")]
        public async Task<ActionResult<List<Ride>>> AllWithoutEndCity(string startCity, DateTime departure)
        {
            List<Ride> rides = await _rideService.GetAll(startCity, departure);
            return Ok(rides);
        }

        /// <summary>
        /// Retourne la liste des trajets disponibles sur le site
        /// </summary>
        [HttpGet("/rides")]
        public ActionResult<List<Ride>> All()
        {
            var rides = _rideService.GetAll();
            return Ok(rides);
        }

        /// <summary>
        /// Retourne la liste de tous les trajets d'un utilisateur
        /// </summary>
        /// <param name="userId">Identifiant d'utilisateur</param>
        [HttpGet("/rides/{userId}")]
        public async Task<ActionResult<List<Ride>>> AllByUserId(Guid userId)
        {
            var rides = await _rideService.GetAll(userId);
            return Ok(rides);
        }

        /// <summary>
        /// Retourne un trajet
        /// </summary>
        /// <param name="id">Identifiant du trajet</param>
        [HttpGet("/ride/{id}")]
        public ActionResult<Ride> GetById(Guid id)
        {
            var ride = _rideService.GetById(id);
            if (ride == null)
                return NotFound();
            return Ok(ride);
        }

        /// <summary>
        /// Crée un trajet à proposer sur le site
        /// </summary>
        [HttpPost("/create")]
        public async Task<ActionResult<Ride>> Create([FromBody] Ride ride)
        {
            Ride? rideAdded = await _rideService.Create(ride);
            if (rideAdded == null)
                return BadRequest();
            return CreatedAtAction(nameof(GetById), new { id = rideAdded.Id }, rideAdded);
        }

        /// <summary>
        /// Supprime un trajet avec ses commentaires/notes/réservations
        /// </summary>
        /// <param name="id">Identifiant du trajet</param>
        [HttpDelete("/ride/{id}")]
        public ActionResult DeleteById(Guid id)
        {
            _rideService.Delete(id);
            return Ok();
        }
    }
}

