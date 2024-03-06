using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using EVS.Core.Models;
using EVS.Api.Repositories;

namespace EVS.Api.Services
{
    internal class UserService(IUserRepository<User> userRepository)
            {
            // Injection de dépendance vers le repository ou le service d'accès aux données des utilisateurs
            public readonly IUserRepository<User> _userRepository = userRepository;

        // Méthode pour récupérer tous les utilisateurs
        public List<User> GetAllUsers() => _userRepository.GetAll();

        // Méthode pour récupérer un utilisateur par son ID
        public Task<User> GetUserById(Guid userId)
            {
                return _userRepository.GetById(userId);
            }

            // Méthode pour créer un nouvel utilisateur
            public void CreateUser(User user)
            {
                _userRepository.Create(user);
            }

            // Méthode pour mettre à jour les informations d'un utilisateur existant
            public void UpdateUser(User user)
            {
                _userRepository.Update(user);
            }

            // Méthode pour supprimer un utilisateur
            public void DeleteUser(Guid userId)
            {
                _userRepository.Delete(userId);
            }
        }

    
}
