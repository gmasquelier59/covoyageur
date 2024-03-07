using EVS.Core.Models;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public Task<Feedback?> Add(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Feedback?> Get(Expression<Func<Feedback, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Feedback>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Feedback>> GetAll(Expression<Func<Feedback, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Feedback?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Feedback?> Update(Feedback feedback)
        {
            throw new NotImplementedException();
        }
    }
}
