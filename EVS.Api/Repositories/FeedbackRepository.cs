using EVS.Api.Data;
using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace EVS.Api.Repositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Feedback> _feedbacks;

        public FeedbackRepository(AppDbContext context)
        {
            _context = context;
            _feedbacks = _context.Set<Feedback>();
        }

        public async Task<Feedback?> Add(Feedback feedback)
        {
            EntityEntry<Feedback> newEntry = await _feedbacks.AddAsync(feedback);

            if (await _context.SaveChangesAsync() > 0)
                return newEntry.Entity;

            return null;
        }

        public async Task<Feedback?> Get(Expression<Func<Feedback, bool>> predicate)
        {
            return await _feedbacks.FirstOrDefaultAsync<Feedback>(predicate);
        }

        public async Task<List<Feedback>> GetAll()
        {
            return await _context.Feedbacks.ToListAsync<Feedback>();
        }

        public async Task<List<Feedback>> GetAll(Expression<Func<Feedback, bool>> predicate)
        {
            return await _context.Feedbacks.Where(predicate).ToListAsync<Feedback>();
        }

        public async Task<Feedback?> GetById(Guid id)
        {
            return await _feedbacks.FirstOrDefaultAsync<Feedback>(f => f.Id == id);
        }

        public async Task<Feedback?> Update(Feedback feedback)
        {
            Feedback? feedbackModified = await GetById(feedback.Id);

            if (feedbackModified == null)
                return null;

            if (feedbackModified.Note != feedback.Note)
                feedbackModified.Note = feedback.Note;

            if (feedbackModified.Comments != feedback.Comments)
                feedbackModified.Comments = feedback.Comments;

            if (await _context.SaveChangesAsync() == 0)
                return null;

            return feedbackModified;
        }
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
