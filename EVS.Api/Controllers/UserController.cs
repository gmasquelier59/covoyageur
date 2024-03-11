using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;
using EVS.Api.Services;
using EVS.Api.DTOs;

namespace EVS.Api.Controllers
{
    [Tags("Utilisateurs")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Retourne la liste de tous les utilisateurs
        /// </summary>
        [HttpGet("/users")]
        public async Task<ActionResult<List<User>>> All()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

        /// <summary>
        /// Retourne les informations d'un utilisateur à partir de son id
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur</param>
        [HttpGet("/user/{id}")]

        public async Task<ActionResult<User>> GetById(Guid id)
        {
            var user = await _userService.GetById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
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
        /// Creation d'un nouvel utilisateur
        /// </summary>
        [HttpPost("/register")]
        public async Task<ActionResult<User>> Create([FromBody] User user)
        {
            User? userAdded = await _userService.Create(user);
            if (userAdded == null)
                return BadRequest();
            return CreatedAtAction(nameof(GetById), new { id = userAdded.Id }, userAdded);
        }

        /*        public async Task<ActionResult<User>> Create([FromBody] User user)
                {
                    if (await _userRepository.Get(u => u.Email == user.Email) != null)
                        return BadRequest();

                    user.PassWord = EncryptPassword(user.PassWord);            

                    if (await _userRepository.Add(user) > 0)
                        return CreatedAtAction(nameof(GetById), new { id = userAdded.Id }, userAdded);
                    return BadRequest();
                }*/


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
        public async Task<ActionResult<User>> Update(Guid id, [FromBody] UserDTO userDTO)
        {
            User? user = await _userService.Update(id, userDTO);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        /// <summary>
        /// Supprime un utilisateur à partir de son id (supprime également les trajets, les réservations et les feedbacks associés)
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur</param>
        [HttpDelete("/user/{id}")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            if (await _userService.Delete(id) == false)
                return NotFound();
            return NoContent();
        }
    }
}
