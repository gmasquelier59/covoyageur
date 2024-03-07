using EVS.Core.Models;
using EVS.Api.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace EVS.Api.Repositories
{
    public class RideRepository : IRepository<Ride>
    {
        private readonly AppDbContext _context;

        public RideRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ride>> GetAll()
        {
            return await _context.Rides.ToListAsync<Ride>();
        }

        public async Task<List<Ride>> GetAll(Expression<Func<Ride, bool>> predicate)
        {
            return await _context.Rides
                .Where(predicate)
                .ToListAsync<Ride>();
        }

        public async Task<Ride?> GetById(Guid id)
        {
            return await _context.Rides.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Ride?> Add(Ride ride)
        {
            var addEntry = await _context.Rides.AddAsync(ride);
            await _context.SaveChangesAsync();

            if (addEntry.Entity.Id != Guid.Empty)
                return addEntry.Entity;
            return null;
        }

        public Task<Ride?> Get(Expression<Func<Ride, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ride?> Update(Ride ride)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            var ride = await GetById(id);
            if (ride != null)
            {
                _context.Rides.Remove(ride);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}

