using EVS.Core.Models;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public class RideRepository : IRideRepository
    {
        public Task<Guid> Add(Ride ride) 
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Ride?> Get(Expression<Func<Ride, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        //public Task<List<Ride>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public Task<List<Ride>> GetAll(Expression<Func<Ride, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ride?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Ride ride)
        {
            throw new NotImplementedException();
        }
    }
}
