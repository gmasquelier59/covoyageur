// UserService.cs

using EVS.Core.Models;
using System;
using System.Collections.Generic;

namespace EVS.Api.Services
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            // Logique pour récupérer tous les utilisateurs depuis la base de données, par exemple
            throw new NotImplementedException();
        }

        public User GetUserById(Guid userId)
        {
            // Logique pour récupérer un utilisateur par son identifiant depuis la base de données, par exemple
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            // Logique pour ajouter un nouvel utilisateur dans la base de données, par exemple
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            // Logique pour mettre à jour les informations d'un utilisateur existant dans la base de données, par exemple
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid userId)
        {
            // Logique pour supprimer un utilisateur de la base de données, par exemple
            throw new NotImplementedException();
        }

       public User GetConnectedUser(Guid userId)
        { throw new NotImplementedException(); }

       public User UpdatedConnectedUser(Guid userId)
        { throw new NotImplementedException(); }
    }
}


/*

POST
/login
Retourne un token JWT d'authentification pour un utilisateur*/

