using EVS.Api.Data;
using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<User> _users;

        public UserRepository(AppDbContext context)
        {
            _context = context;
            _users = _context.Set<User>();
        }
        public async Task<User?> Add(User user)
        {
            var addEntry = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            if (addEntry.Entity.Id != Guid.Empty)
                return addEntry.Entity;
            return null;
        }

        public async Task<bool> Delete(Guid id)
        {
            var user = await GetById(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<User?> Get(Expression<Func<User, bool>> predicate)
        {
            return await _users.FirstOrDefaultAsync<User>(predicate);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync<User>();
        }

        public async Task<List<User>> GetAll(Expression<Func<User, bool>> predicate)
        {
            return await _context.Users.Where(predicate).ToListAsync<User>();
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User?> Update(User user)
        {
            User? userToUpdate = await GetById(user.Id);

            if (userToUpdate == null)
                return null;

            if (userToUpdate.LastName != user.LastName)
                userToUpdate.LastName = user.LastName;

            if (userToUpdate.FirstName != user.FirstName)
                userToUpdate.FirstName = user.FirstName;

            if (userToUpdate.Pseudo != user.Pseudo)
                userToUpdate.Pseudo = user.Pseudo;

            if (userToUpdate.Email != user.Email)
                userToUpdate.Email = user.Email;

            if (userToUpdate.Password != user.Password)
                userToUpdate.Password = user.Password;

            if (userToUpdate.PhoneNumber != user.PhoneNumber)
                userToUpdate.PhoneNumber = user.PhoneNumber;

            if (userToUpdate.Birthday != user.Birthday)
                userToUpdate.Birthday = user.Birthday;

            if (userToUpdate.Photo != user.Photo)
                userToUpdate.Photo = user.Photo;

            if (userToUpdate.CarDescription != user.CarDescription)
                userToUpdate.CarDescription = user.CarDescription;

            if (userToUpdate.IsAdmin != user.IsAdmin)
                userToUpdate.IsAdmin = user.IsAdmin;

            if (userToUpdate.AcceptSmoker != user.AcceptSmoker)
                userToUpdate.AcceptSmoker = user.AcceptSmoker;

            if (userToUpdate.AcceptPet != user.AcceptPet)
                userToUpdate.AcceptPet = user.AcceptPet;

            if (userToUpdate.AcceptSmallTalk != user.AcceptSmallTalk)
                userToUpdate.AcceptSmallTalk = user.AcceptSmallTalk;

            if (userToUpdate.AcceptMusic != user.AcceptMusic)
                userToUpdate.AcceptMusic = user.AcceptMusic;

            if (userToUpdate.AcceptFood != user.AcceptFood)
                userToUpdate.AcceptFood = user.AcceptFood;

            if (await _context.SaveChangesAsync() == 0)
                return null;

            return userToUpdate;
        }
    }
}