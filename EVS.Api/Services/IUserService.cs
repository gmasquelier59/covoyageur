using EVS.Api.DTOs;
using EVS.Core.Models;
using System.Linq.Expressions;

namespace EVS.Api
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
        public Task<User?> GetById(Guid id);
        public Task<User?> Get(Expression<Func<User, bool>> predicate);
        public Task<User?> Create(User user);
        public Task<string?> Login(string email, string password);
        public Task<User?> Update(Guid id, UserDTO userDTO);
        public Task<bool> Delete(Guid id);
    }
}
