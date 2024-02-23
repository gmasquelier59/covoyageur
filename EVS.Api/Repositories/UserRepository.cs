 using EVS.Core.Models;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        public Task<User> Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User user)
        {
            throw new NotImplementedException();
        }

        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        Task<Guid> IUserRepository<User>.Add(User user)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository<User>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
