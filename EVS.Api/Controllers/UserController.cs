using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;

namespace EVS.Api.Controllers
{
    [Tags("Utilisateurs")]
    [ApiController]
    public class UserController : Controller
    {
        /// <summary>
        /// Retourne la liste de tous les utilisateurs
        /// </summary>
        [HttpGet("/users")]
        public ActionResult<List<User>> All()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les informations d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur</param>
        [HttpGet("/user/{id}")]
        public ActionResult<User> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne les informations de l'utilisateur connecté
        /// </summary>
        [HttpGet("/user")]
        public ActionResult<User> GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enregistre un nouvel utilisateur (non administrateur)
        /// </summary>
        [HttpPost("/register")]
        public ActionResult<User> Register([FromBody] User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retourne un token JWT d'authentification pour un utilisateur
        /// </summary>
        [HttpPost("/login")]
        public ActionResult Login([FromBody] User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Met à jour les informations de l'utilisateur connecté
        /// </summary>
        [HttpPut("/user")]
        public ActionResult<User> Update()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Supprime un utilisateur à partir de son id (supprime également les trajets, les réservations et les feedbacks associés)
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur</param>
        [HttpDelete("/user/{id}")]
        public ActionResult DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
