using Microsoft.AspNetCore.Mvc;
using EVS.Core.Models;
using EVS.Api.Services;
using EVS.Api.DTOs;
using Microsoft.AspNetCore.Identity.Data;
using EVS.Api.Helpers;
using EVS.Api.Repositories;
using Microsoft.Extensions.Options;
using System.Runtime;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EVS.Api.Controllers
{
    [Tags("Utilisateurs")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly AppSettings _settings;
        private readonly string _securityKey = "clé super secrète";

        public UserController(IUserService userService, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
        _settings = appSettings.Value;
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
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            try
            {
                await _userService.Create(user);
                return Ok(new { Message = "User created!" });
            }
            catch (Exception ex)
            {
                return BadRequest($"Registration failed: {ex.Message}");
            }
        }


        /*        [HttpPost("login")]
                public async Task<IActionResult> Login([FromBody] LoginRequestDTO login)
                {
                    try
                    {
                        var authenticationResult = await _userService.Login(login);
                        if (authenticationResult.Success)
                        {
                            return Ok(new
                            {
                                Token = authenticationResult.Token,
                                Message = "Valid Authentication !",
                                User = authenticationResult.User
                            });
                        }
                        return BadRequest("Invalid Authentication !");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest($"Login failed: {ex.Message}");
                    }
                }*/


        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            string? token = await _userService.Login(request.Email, request.Password);

            if (token != null)
            {
                return Ok(new { Token = token });
            }

            return Unauthorized();
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
