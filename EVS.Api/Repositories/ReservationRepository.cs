using EVS.Api.Data;
using EVS.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using static System.Collections.Specialized.BitVector32;

namespace EVS.Api.Repositories
{
    public class ReservationRepository : IRepository<Reservation>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Reservation> _reservations;

        public ReservationRepository(AppDbContext context)
        {
            _context = context;
            _reservations = _context.Set<Reservation>();
        }

        public async Task<Reservation?> Add(Reservation reservation)
        {
            EntityEntry<Reservation> newEntry = await _reservations.AddAsync(reservation);

            if (await _context.SaveChangesAsync() > 0)
                return newEntry.Entity;

            return null;
        }

        public async Task<bool> Delete(Guid id)
        {
            Reservation? reservationToDelete = await GetById(id);

            if (reservationToDelete == null)
                return false;

            _context.Remove(reservationToDelete);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Reservation?> Get(System.Linq.Expressions.Expression<Func<Reservation, bool>> predicate)
        {
            return await _reservations.FirstOrDefaultAsync<Reservation>(predicate);
        }

        public async Task<List<Reservation>> GetAll()
        {
            return await _reservations.ToListAsync<Reservation>();
        }

        public async Task<List<Reservation>> GetAll(System.Linq.Expressions.Expression<Func<Reservation, bool>> predicate)
        {
            return await _reservations.Where(predicate).ToListAsync<Reservation>();
        }

        public async Task<Reservation?> GetById(Guid id)
        {
            return await _reservations.FirstOrDefaultAsync<Reservation>(r => r.Id == id);
        }

        public async Task<Reservation?> Update(Reservation reservation)
        {
            Reservation? reservationToUpdate = await GetById(reservation.Id);

            if (reservationToUpdate == null)
                return null;

            if (reservationToUpdate.Status != reservation.Status)
                reservationToUpdate.Status = reservation.Status;

            if (reservationToUpdate.ReservationDate != reservation.ReservationDate)
                reservationToUpdate.ReservationDate = reservation.ReservationDate;

            if (await _context.SaveChangesAsync() == 0)
                return null;

            return reservationToUpdate;
        }
    }
}
