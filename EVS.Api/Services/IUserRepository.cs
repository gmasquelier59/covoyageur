using EVS.Core.Models;

namespace EVS.Core.Services
{
    internal interface IUserRepository
    {
        void Delete(int userId);
        IEnumerable<User> GetAll();
        User GetById(Guid userId);
        void Update(User user);
        void Create(User user);
    }
}