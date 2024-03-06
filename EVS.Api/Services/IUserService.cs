// IUserService.cs

using EVS.Core.Models;
using System.Collections.Generic;

namespace EVS.Api
{
    public interface IUserService
    {
        // Méthode pour récupérer tous les utilisateurs
        List<User> GetAllUsers();

        // Méthode pour récupérer un utilisateur par son identifiant
        User GetUserById(Guid userId);

        // Méthode pour ajouter un nouvel utilisateur
        void AddUser(User user);

        // Méthode pour mettre à jour les informations d'un utilisateur existant
        void UpdateUser(User user);

        // Méthode pour supprimer un utilisateur
        void DeleteUser(Guid userId);
    }
}
