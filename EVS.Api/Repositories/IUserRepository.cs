using EVS.Core.Models;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public interface IUserRepository<User> where User : class
    {

             
        Task<Guid> Add(User user);

    
        public Task<User> GetById(Guid id);

        Task<User> Get(Expression<Func<User, bool>> predicate);


        //Task<List<User>> GetAll(Expression<Func<User, bool>> predicate);
        public List<User> GetAll();
        public User Create(User user);

        Task<bool> Update(User user);

        
        Task<bool> Delete(Guid id);
    }

    
}
