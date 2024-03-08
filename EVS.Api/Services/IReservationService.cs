using EVS.Core.Enums;
using EVS.Core.Models;

namespace EVS.Api.Services
{
    public interface IReservationService
    {
        public Task<List<Reservation>> GetAllByRideId(Guid rideId);

        public Task<Reservation?> Create(Guid rideId, Guid userId);

        public Task<Reservation?> UpdateStatus(Guid id, ReservationStatus newStatus);
    }
}
