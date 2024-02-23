using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;

namespace EVS.Api.Controllers
{
    [Route("/ride")]
    [Tags("Trajets")]
    [ApiController]
    public class RideController : Controller
    {
        /// <summary>
        /// Retourne la liste des trajets correspondants aux 3 critères
        /// </summary>
        /// <param name="startCity">Nom de la ville de départ</param>
        /// <param name="endCity">Nom de la ville de d'arrivée</param>
        /// <param name="departure">Date de départ</param>
        [HttpGet("/rides/{startCity}/{endCity}/{departure}")]
        public IActionResult AllWithEndCity(string startCity, string endCity, DateTime departure)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne la liste des trajets correspondants aux critères départ/date sans destination précise
        /// </summary>
        /// <param name="startCity">Nom de la ville de départ</param>        
        /// <param name="departure">Date de départ</param>
        [HttpGet("/rides/{startCity}/{departure}")]
        public IActionResult AllWithoutEndCity(string startCity, DateTime departure)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne la liste des trajets disponibles sur le site
        /// </summary>
        [HttpGet("/rides")]
        public IActionResult All()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne la liste de tous les trajets d'un utilisateur
        /// </summary>
        /// <param name="userId">Identifiant d'utilisateur</param>
        [HttpGet("/rides/{userId}")]
        public IActionResult AllByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne un trajet précis
        /// </summary>
        /// <param name="id">Identifiant du trajet</param>
        [HttpGet("/ride/{id}")]
        public IActionResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crée un trajet à proposer sur le site
        /// </summary>
        [HttpPost("/create")]
        public IActionResult Create([FromBody]Ride ride)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Supprime un trajet avec ses commentaires/notes/réservations
        /// </summary>
        /// <param name="id">Identifiant du trajet</param>
        [HttpDelete("/ride/{id}")]
        public IActionResult DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
