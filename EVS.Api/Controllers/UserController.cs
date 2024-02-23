using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;

namespace EVS.Api.Controllers
{
    [Route("/user")]
    [Tags("Utilisateurs")]
    [ApiController]
    public class UserController : Controller
    {
        /// <summary>
        /// Retourne la liste de tous les utilisateurs
        /// </summary>
        [HttpGet("/users")]
        public IActionResult All()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les informations d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur</param>
        [HttpGet("/user/{id}")]
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les informations de l'utilisateur connecté
        /// </summary>
        [HttpGet("/user")]
        public IActionResult GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enregistre un nouvel utilisateur (non administrateur)
        /// </summary>
        [HttpPost("/register")]
        public IActionResult Register(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne un token JWT d'authentification pour un utilisateur
        /// </summary>
        [HttpPost("/login")]
        public IActionResult Login(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Met à jour les informations de l'utilisateur connecté
        /// </summary>
        [HttpPut("/user")]
        public IActionResult Update()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Supprime un utilisateur à partir de son id (supprime également les trajets, les réservations et les feedbacks associés)
        /// </summary>
        [HttpDelete("/user/{id}")]
        public IActionResult DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
