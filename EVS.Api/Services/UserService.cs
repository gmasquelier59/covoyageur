using EVS.Api.DTOs;
using EVS.Api.Repositories;
using EVS.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EVS.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task<User?> GetById(Guid id)
        {
            User? user = await _userRepository.GetById(id);
            if (user != null)
                user.Rating = await ComputeUserRating(user);

            return user;
        }

        private async Task<int> ComputeUserRating(User user)
        {
            Random rand = new Random();

            return rand.Next(1, 5);
        }

        public async Task<User?> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<User?> Create(User user)
        {
            return await _userRepository.Add(user);
        }

        public Task<User?> Login(string email, string password)
        {
            throw new NotImplementedException();
        }
        public async Task<User?> Update(Guid id, UserDTO userDTO)
        {
            User? user = await _userRepository.GetById(id);

            if (user == null)
                return null;

            user.LastName = userDTO.LastName;
            user.FirstName = userDTO.FirstName;
            user.Pseudo = userDTO.Pseudo;
            user.Email = userDTO.Email;
            user.Password = userDTO.Password;
            user.PhoneNumber = userDTO.PhoneNumber;
            user.Birthday = userDTO.Birthday;
            user.Photo = userDTO.Photo;
            user.CarDescription = userDTO.CarDescription;            
            user.AcceptSmoker = userDTO.AcceptSmoker;
            user.AcceptPet = userDTO.AcceptPet;
            user.AcceptSmallTalk = userDTO.AcceptSmallTalk;
            user.AcceptMusic = userDTO.AcceptMusic;
            user.AcceptFood = userDTO.AcceptFood;

            return await _userRepository.Update(user);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _userRepository.Delete(id);
        }
    }
}

/*

POST
/login
Retourne un token JWT d'authentification pour un utilisateur*/

