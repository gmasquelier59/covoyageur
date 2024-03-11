using EVS.Api.DTOs;
using EVS.Core.Models;

namespace EVS.Api
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
        public Task<User?> GetById(Guid id);
        public Task<User?> Get();
        public Task<User?> Create(User user);
        public Task<User?> Login(string email, string password);
        public Task<User?> Update(Guid id, UserDTO userDTO);
        public Task<bool> Delete(Guid id);
    }
}
