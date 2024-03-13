﻿using Microsoft.AspNetCore.Mvc;
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
        /// Retourne la liste des trajets correspondants aux 4 critères
        /// </summary>
        /// <param name="startCity">Nom de la ville de départ</param>
        /// <param name="endCity">Nom de la ville de d'arrivée</param>
        /// <param name="departure">Date de départ</param>
        /// <param name="seats">Nombre de sièges</param>
        [HttpGet("/rides/{startCity}/{endCity}/{departure}/{seats}")]
        public async Task<ActionResult<List<Ride>>> AllWithEndCity(string startCity, string endCity, DateTime departure, int seats)
        {
            List<Ride> rides = await _rideService.GetAll(startCity, endCity, departure, seats);
            return Ok(rides);
        }

		/// <summary>
		/// Retourne la liste des trajets correspondants aux critères départ/date sans destination précise
		/// </summary>
		/// <param name="startCity">Nom de la ville de départ</param>        
		/// <param name="departure">Date de départ</param>
		/// /// <param name="seats">Nombre de sièges</param>
		[HttpGet("/rides/{startCity}/{departure}/{seats}")]
        public async Task<ActionResult<List<Ride>>> AllWithoutEndCity(string startCity, DateTime departure, int seats)
        {
            List<Ride> rides = await _rideService.GetAll(startCity, departure, seats);
            return Ok(rides);
        }

        /// <summary>
        /// Retourne la liste des trajets disponibles sur le site
        /// </summary>
        [HttpGet("/rides")]
        public async Task<ActionResult<List<Ride>>> All()
        {
            var rides = await _rideService.GetAll();
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
        public async Task<ActionResult<Ride>> GetById(Guid id)
        {
            var ride = await _rideService.GetById(id);
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
        public async Task<ActionResult> DeleteById(Guid id)
        {
            if (await _rideService.Delete(id) == false)
                return NotFound();
            return NoContent();
        }
    }
}

